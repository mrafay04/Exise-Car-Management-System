using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class AdminForm : Form
    {
        string connectionString = "Server=localhost;Database=CarDB;Trusted_Connection=True;";


        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string strConnection)
        {
            connectionString = strConnection;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            AddOwnerForm a = new AddOwnerForm("", connectionString);
            a.ShowDialog();
            LoadOwner();
        }

        // 🔹 Row-select Delete code
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // selected row se CNIC uthao
                string selectedCNIC = dataGridView1.SelectedRows[0].Cells["CNIC"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete owner with CNIC: {selectedCNIC}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Owners WHERE CNIC = @CNIC";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CNIC", selectedCNIC);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Owner deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // refresh grid
                                LoadOwner();
                            }
                            else
                            {
                                MessageBox.Show("No owner found with this CNIC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadOwner();
        }

        private void LoadOwner()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select V.*, O.[Name], O.CNIC from vehicle v, owners o where v.ownerid = o.OwnerID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query;

                if (txtCNIC.Text == "" && txtRegistrationNumber.Text == "")
                {
                    // Agar kuch search nahi kiya
                    query = @"SELECT V.*, O.[Name], O.CNIC 
                      FROM Vehicle V 
                      INNER JOIN Owners O ON V.OwnerID = O.OwnerID 
                      ORDER BY V.VehicleNumber ASC";
                }
                else
                {
                    // Pehle matching records lo (upar dikhne ke liye)
                    query = @"SELECT V.*, O.[Name], O.CNIC 
                      FROM Vehicle V
                      INNER JOIN Owners O ON V.OwnerID = O.OwnerID
                      WHERE (V.VehicleNumber LIKE @VehicleNumber OR O.CNIC LIKE @CNIC)

                      UNION ALL

                      -- Baaki sab records neeche
                      SELECT V.*, O.[Name], O.CNIC 
                      FROM Vehicle V
                      INNER JOIN Owners O ON V.OwnerID = O.OwnerID
                      WHERE (V.VehicleNumber NOT LIKE @VehicleNumber AND O.CNIC NOT LIKE @CNIC)

                      ORDER BY VehicleNumber ASC";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@VehicleNumber", "%" + txtRegistrationNumber.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@CNIC", "%" + txtCNIC.Text.Trim() + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                        dataGridView1.DataSource = null;
                    }
                }
            }
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegistrationNumber.Clear();
            txtCNIC.Clear();
            dataGridView1.DataSource = null;
            txtRegistrationNumber.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedCNIC = dataGridView1.SelectedRows[0].Cells["CNIC"].Value.ToString();

                AddOwnerForm form = new AddOwnerForm(selectedCNIC, connectionString);
                form.ShowDialog();

                LoadOwner();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void btnRemoveOwner_Click(object sender, EventArgs e)
        //{

        //}
        private void btnRemoveOwner_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Selected row ka CNIC nikal lo
                string selectedCNIC = dataGridView1.SelectedRows[0].Cells["CNIC"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this owner?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Pehle vehicle records delete karo (agar constraint laga ho)
                        string deleteVehiclesQuery = "DELETE FROM Vehicle WHERE OwnerID IN (SELECT OwnerID FROM Owners WHERE CNIC = @CNIC)";
                        using (SqlCommand cmdVehicles = new SqlCommand(deleteVehiclesQuery, conn))
                        {
                            cmdVehicles.Parameters.AddWithValue("@CNIC", selectedCNIC);
                            cmdVehicles.ExecuteNonQuery();
                        }

                        // Ab Owner delete karo
                        string deleteOwnerQuery = "DELETE FROM Owners WHERE CNIC = @CNIC";
                        using (SqlCommand cmdOwner = new SqlCommand(deleteOwnerQuery, conn))
                        {
                            cmdOwner.Parameters.AddWithValue("@CNIC", selectedCNIC);
                            int rows = cmdOwner.ExecuteNonQuery();

                            if (rows > 0)
                                MessageBox.Show("Owner deleted successfully.");
                            else
                                MessageBox.Show("No owner found with this CNIC.");
                        }
                    }

                    // Grid refresh
                    LoadOwner();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
