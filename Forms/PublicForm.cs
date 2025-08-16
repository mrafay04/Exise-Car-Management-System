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
            this.Close();
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

                    // ✅ JOIN query: Vehicle + Owner
                    string query = @"SELECT V.VehicleNumber, V.VehicleType, V.ModelYear, 
                                            V.EngineNumber, V.ChassisNumber, V.Color,
                                            O.Name AS OwnerName, O.CNIC
                                     FROM Vehicle V
                                     INNER JOIN Owners O ON V.OwnerID = O.OwnerID
                                     WHERE V.VehicleNumber = @VehicleNumber";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VehicleNumber", vehicleNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // ✅ ab Owner Name bhi aa raha hai
                        lblResult.Text =
                                         $"Owner Name: {row["OwnerName"]}\n"+
                                         $"Vehicle Number: {row["VehicleNumber"]}\n" +
                                         $"Vehicle Type: {row["VehicleType"]}\n" +
                                         $"Model Year: {row["ModelYear"]}\n" +
                                         $"Engine Number: {row["EngineNumber"]}\n" +
                                         $"Chassis Number: {row["ChassisNumber"]}\n" +
                                         $"Color: {row["Color"]}\n" +
                                         $"Owner Name: {row["OwnerName"]}\n";
                                      //   $"Owner CNIC: {row["CNIC"]}";

                        lblResultordataGridView1.DataSource = dt; // grid pe bhi data show
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

        private void button1_Click(object sender, EventArgs e)
        {
            ContactForm h = new ContactForm();
            h.ShowDialog();
        }

        private void PublicForm_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
