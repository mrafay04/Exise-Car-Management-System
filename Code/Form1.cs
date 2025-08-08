namespace CarVerification
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.SelectedItem?.ToString(); // Get selected role

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            if (role == "Admin" && username == "admin" && password == "123")
            {
                AdminForm admin = new AdminForm();
                admin.Show();
                this.Hide();
            }
            else if (role == "Public" && username == "public" && password == "123")
            {
                PublicForm publicForm = new PublicForm();
                publicForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: Invalid credentials or role! Try Again");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Add role options in ComboBox
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Public");
            comboBox1.SelectedIndex = 0; // Default selection
        }
    }
}
