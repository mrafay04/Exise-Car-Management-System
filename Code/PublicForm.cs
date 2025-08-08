using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class PublicForm : Form
    {
        public PublicForm()
        {
            InitializeComponent();
        }

        private void txtVehicleNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                VerifyVehicle();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Close();
            l.Show();
        }

        private void VerifyVehicle()
        {
            string vehicleNumber = txtVehicleNumber.Text.Trim();

            if (string.IsNullOrEmpty(vehicleNumber))
            {
                MessageBox.Show("Please enter a vehicle number.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CarDB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Vehicle WHERE VehicleNumber = @VehicleNumber";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VehicleNumber", vehicleNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        lblResult.Text = $"Vehicle Type: {row["VehicleType"]}\n" +
                                         $"Model Year: {row["ModelYear"]}\n" +
                                         $"Engine Number: {row["EngineNumber"]}\n" +
                                         $"Chassis Number: {row["ChassisNumber"]}\n" +
                                         $"Color: {row["Color"]}\n" +
                                         $"Owner Name: {row["OwnerName"]}\n" +
                                         $"CNIC: {row["CNIC"]}";

                        lblResultordataGridView1.DataSource = dt;
                    }
                    else
                    {
                        lblResult.Text = "No record found for this vehicle number.";
                        lblResultordataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}