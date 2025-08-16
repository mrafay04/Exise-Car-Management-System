namespace CarVerification
{
    partial class AddOwnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtCNIC = new TextBox();
            txtContact = new TextBox();
            btnAddOwner = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Padding = new Padding(20);
            label2.Size = new Size(170, 65);
            label2.TabIndex = 2;
            label2.Tag = "zz";
            label2.Text = "Enter  Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 68);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(163, 65);
            label1.TabIndex = 3;
            label1.Tag = "zz";
            label1.Text = "Enter CNIC  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 124);
            label3.Name = "label3";
            label3.Padding = new Padding(20);
            label3.Size = new Size(254, 65);
            label3.TabIndex = 4;
            label3.Text = "Enter Contact Number : ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(261, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 33);
            txtName.TabIndex = 5;
            // 
            // txtCNIC
            // 
            txtCNIC.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNIC.Location = new Point(261, 88);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(243, 33);
            txtCNIC.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(261, 141);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(243, 33);
            txtContact.TabIndex = 7;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOwner.Location = new Point(213, 238);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(137, 39);
            btnAddOwner.TabIndex = 8;
            btnAddOwner.Text = "Add Owner";
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(369, 238);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 39);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "&Close";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddOwner);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCNIC);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 300);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // AddOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(585, 321);
            Controls.Add(groupBox1);
            Name = "AddOwnerForm";
            Text = "Add Owner";
            Load += AddOwnerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private TextBox txtCNIC;
        private TextBox txtContact;
        private Button btnAddOwner;
        private Button btnLogout;
        private GroupBox groupBox1;
    }
}