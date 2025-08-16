using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarVerification
{

    public partial class MainForm : Form
    {
        string connectionString = "Server=localhost;Database=CarDB;Trusted_Connection=True;";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublicForm p = new PublicForm();
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContactForm c = new ContactForm();
            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
