using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class RemoveOwnerForm : Form
    {
        public RemoveOwnerForm()
        {
            InitializeComponent();
        }

        // ✅ Yeh method zaroori hai (designer file error is se solve hoga)
        private void RemoveOwnerForm_Load(object sender, EventArgs e)
        {
            // Agar form load pe kuch karna hai to yahan likho (abhi blank chalega)
        }

        // ✅ Button Click Event: CNIC se owner delete karega
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Step 1: Get CNIC from textbox
            string cnic = txtCNIC.Text.Trim();

            // Step 2: Validate input
            if (string.IsNullOrEmpty(cnic))
            {
                MessageBox.Show("Please enter CNIC.");
                return;
            }

            // Step 3: Set your actual SQL connection string here
            string connectionString = "Data Source=localhost;Initial Catalog=CarDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Owners WHERE CNIC = @cnic";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cnic", cnic);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Owner deleted successfully.");
                        txtCNIC.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No owner found with this CNIC.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

        }
    }
}