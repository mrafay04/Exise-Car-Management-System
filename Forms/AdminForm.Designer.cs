using System.Drawing;
using System.Windows.Forms;

namespace CarVerification
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Button btnAddOwner;
        private Button btnRemoveOwner;
        private Button btnLogout;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private Button btnEdit;
        private TextBox txtRegistrationNumber;
        private TextBox txtCNIC;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddOwner = new Button();
            btnRemoveOwner = new Button();
            btnLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            btnEdit = new Button();
            txtRegistrationNumber = new TextBox();
            txtCNIC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, -7);
            label1.Name = "label1";
            label1.Padding = new Padding(30);
            label1.Size = new Size(316, 90);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Admin Portal";
            // 
            // btnAddOwner
            // 
            btnAddOwner.Font = new Font("Segoe UI Historic", 14.25F);
            btnAddOwner.Location = new Point(81, 433);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(107, 33);
            btnAddOwner.TabIndex = 2;
            btnAddOwner.Text = "&Add Owner";
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnRemoveOwner
            // 
            btnRemoveOwner.Font = new Font("Segoe UI Historic", 14.25F);
            btnRemoveOwner.Location = new Point(311, 432);
            btnRemoveOwner.Name = "btnRemoveOwner";
            btnRemoveOwner.Size = new Size(103, 34);
            btnRemoveOwner.TabIndex = 3;
            btnRemoveOwner.Text = "&Remove Owner";
            btnRemoveOwner.UseVisualStyleBackColor = true;
            btnRemoveOwner.Click += btnRemoveOwner_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F);
            btnLogout.Location = new Point(600, 432);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "&Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(427, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 196);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(803, 218);
            dataGridView1.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(205, 432);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(124, 54);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(127, 23);
            txtRegistrationNumber.TabIndex = 8;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(310, 57);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(192, 23);
            txtCNIC.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 10;
            label2.Text = "RegistrationNo.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(266, 60);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "CNIC:";
            // 
            // btnSearch
            // 
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(543, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtRegistrationNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCNIC);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(81, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 103);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Search";
            // 
            // btnClear
            // 
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(543, 74);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = btnLogout;
            ClientSize = new Size(848, 569);
            ControlBox = false;
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnLogout);
            Controls.Add(btnRemoveOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
