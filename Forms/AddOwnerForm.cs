using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class AddOwnerForm : Form
    {
        // Database connection string
        string connectionString = "";//@"Data Source=localhost;Initial Catalog=CarDB;Integrated Security=True";

        // Edit mode ke liye CNIC store
        private string _cnicToEdit = "";

        // Constructor: agar CNIC mile to Edit Mode, warna Add Mode
        public AddOwnerForm(string cnic = "", string strConnection = "")
        {
            InitializeComponent();
            _cnicToEdit = cnic;
            connectionString = strConnection;
        }

        // Form Load event
        private void AddOwnerForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_cnicToEdit))
            {
                btnAddOwner.Text = "Update Owner";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Name, CNIC, Contact FROM Owners WHERE CNIC = @CNIC", conn);
                    cmd.Parameters.AddWithValue("@CNIC", _cnicToEdit);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtCNIC.Text = reader["CNIC"].ToString();
                        txtContact.Text = reader["Contact"].ToString();

                        // Edit mode me CNIC change nahi hoga
                        //txtCNIC.Enabled = false;
                    }
                }
            }
            else
            {
                btnAddOwner.Text = "Add Owner";
            }
        }

        // Add / Update Button click
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string cnic = txtCNIC.Text.Trim();
            string contact = txtContact.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(cnic) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd;
                    if (!string.IsNullOrEmpty(_cnicToEdit)) // Edit Mode
                    {
                        cmd = new SqlCommand(
                            "UPDATE Owners SET Name = @Name, Contact = @Contact WHERE CNIC = @CNIC", conn);
                        cmd.Parameters.AddWithValue("@CNIC", _cnicToEdit);
                    }
                    else // Add Mode
                    {
                        cmd = new SqlCommand(
                            "INSERT INTO Owners (Name, CNIC, Contact) VALUES (@Name, @CNIC, @Contact)", conn);
                        cmd.Parameters.AddWithValue("@CNIC", cnic);
                    }

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show(
                            !string.IsNullOrEmpty(_cnicToEdit) ? "Owner updated successfully!" : "Owner added successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Logout / Close Button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

