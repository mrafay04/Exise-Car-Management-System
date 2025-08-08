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
    public partial class AdminForm : Form
    {
        public AdminForm()
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
            AddOwnerForm a = new AddOwnerForm();
            a.Show();
        }

        private void btnRemoveOwner_Click_1(object sender, EventArgs e)
        {
            RemoveOwnerForm r = new RemoveOwnerForm();
            r.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
