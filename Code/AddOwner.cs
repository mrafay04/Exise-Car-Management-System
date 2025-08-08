using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class AddOwnerForm : Form
    {
        // Apni SQL Server connection string yahan set karo
        string connectionString = @"Data Source=localhost;Initial Catalog=CarDB;Integrated Security=True";

        public AddOwnerForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string cnic = txtCNIC.Text.Trim();
            string contact = txtContact.Text.Trim();

            // Basic validation
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

                    string query = "INSERT INTO Owners (Name, CNIC, Contact) VALUES (@Name, @CNIC, @Contact)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@CNIC", cnic);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Owner added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtCNIC.Clear();
                        txtContact.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add owner!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddOwnerForm_Load(object sender, EventArgs e)
        {
            // Agar form load par kuch karna ho to yahan likho, varna empty chhod do
        }
    }
}
