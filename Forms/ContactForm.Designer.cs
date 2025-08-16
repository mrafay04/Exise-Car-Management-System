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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 29);
            label2.Name = "label2";
            label2.Padding = new Padding(20);
            label2.Size = new Size(170, 65);
            label2.TabIndex = 2;
            label2.Text = "Enter  Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 94);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(161, 65);
            label1.TabIndex = 3;
            label1.Text = "Enter Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 159);
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
            txtName.Location = new Point(187, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 33);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(187, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 33);
            txtEmail.TabIndex = 6;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(187, 180);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(361, 44);
            txtMessage.TabIndex = 7;
            txtMessage.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(255, 224, 192);
            btnSend.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(594, 182);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(108, 42);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(642, 345);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(119, 51);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Close";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 433);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Complain Screen";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "ContactForm";
            Text = "HelpForm";
            Load += ContactForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}