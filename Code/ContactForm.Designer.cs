namespace CarVerification
{
    partial class ContactForm
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
            txtEmail = new TextBox();
            txtMessage = new RichTextBox();
            btnSend = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 33);
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
            label1.Location = new Point(140, 118);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(161, 65);
            label1.TabIndex = 3;
            label1.Text = "Enter Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 209);
            label3.Name = "label3";
            label3.Padding = new Padding(20);
            label3.Size = new Size(189, 65);
            label3.TabIndex = 4;
            label3.Text = "Enter Message : ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(224, 224, 224);
            txtName.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(361, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 33);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(361, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 33);
            txtEmail.TabIndex = 6;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(361, 200);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(361, 96);
            txtMessage.TabIndex = 7;
            txtMessage.Text = "";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(361, 340);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(142, 77);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(526, 351);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 54);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += this.btnLogout_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ContactForm";
            Text = "HelpForm";
            Load += ContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private RichTextBox txtMessage;
        private Button btnSend;
        private Button btnLogout;
    }
}