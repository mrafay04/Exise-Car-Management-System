using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CarVerification
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            this.Load += ContactForm_Load; // Load event bind
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string message = txtMessage.Text.Trim(); // RichTextBox

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Email validation format check
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Save to database
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=CarDB;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO Complaints (Name, Email, Message) VALUES (@Name, @Email, @Message)";
                    // "C" ko apne table ke actual naam se replace karo agar alag hai

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Message", message);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Send Email
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rafayraza489@gmail.com"); // Gmail account
                mail.To.Add("complainexcise@gmail.com"); // Receiving Gmail
                mail.Subject = "New Contact Message from " + name;
                mail.Body = $"Name: {name}\nEmail: {email}\nMessage:\n{message}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("rafayraza489@gmail.com", "iwst flay innd szbc"); // App password
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtEmail.Clear();
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            // Form load hone pe kaam yahan likho
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }
    }
}
