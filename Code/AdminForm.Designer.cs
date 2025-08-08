namespace CarVerification
{
    partial class AdminForm
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
            label1 = new Label();
            btnAddOwner = new Button();
            btnRemoveOwner = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(30);
            label1.Size = new Size(316, 90);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Admin Portal";
            // 
            // btnAddOwner
            // 
            btnAddOwner.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOwner.Location = new Point(294, 203);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(197, 54);
            btnAddOwner.TabIndex = 2;
            btnAddOwner.Text = "Add Owner";
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnRemoveOwner
            // 
            btnRemoveOwner.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveOwner.Location = new Point(294, 306);
            btnRemoveOwner.Name = "btnRemoveOwner";
            btnRemoveOwner.Size = new Size(196, 54);
            btnRemoveOwner.TabIndex = 3;
            btnRemoveOwner.Text = "Remove Owner";
            btnRemoveOwner.UseVisualStyleBackColor = true;
            btnRemoveOwner.Click += btnRemoveOwner_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(99, 397);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 54);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 491);
            Controls.Add(btnLogout);
            Controls.Add(btnRemoveOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddOwner;
        private Button btnRemoveOwner;
        private Button btnLogout;
    }
}