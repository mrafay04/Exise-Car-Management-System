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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 64);
            label2.Name = "label2";
            label2.Padding = new Padding(20);
            label2.Size = new Size(170, 65);
            label2.TabIndex = 2;
            label2.Text = "Enter  Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 168);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(163, 65);
            label1.TabIndex = 3;
            label1.Text = "Enter CNIC  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 277);
            label3.Name = "label3";
            label3.Padding = new Padding(20);
            label3.Size = new Size(254, 65);
            label3.TabIndex = 4;
            label3.Text = "Enter Contact Number : ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(406, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 33);
            txtName.TabIndex = 5;
            // 
            // txtCNIC
            // 
            txtCNIC.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNIC.Location = new Point(406, 183);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(243, 33);
            txtCNIC.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(406, 287);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(243, 33);
            txtContact.TabIndex = 7;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOwner.Location = new Point(471, 396);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(148, 59);
            btnAddOwner.TabIndex = 8;
            btnAddOwner.Text = "Add Owner";
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(125, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 54);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AddOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 499);
            Controls.Add(btnLogout);
            Controls.Add(btnAddOwner);
            Controls.Add(txtContact);
            Controls.Add(txtCNIC);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddOwnerForm";
            Text = "AddOwnerForm";
            Load += AddOwnerForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}