namespace CarVerification
{
    partial class RemoveOwnerForm
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
            txtCNIC = new TextBox();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 133);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(163, 65);
            label1.TabIndex = 4;
            label1.Text = "Enter CNIC  : ";
            // 
            // txtCNIC
            // 
            txtCNIC.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNIC.Location = new Point(374, 147);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(243, 33);
            txtCNIC.TabIndex = 7;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(323, 277);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(148, 59);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Delete Owner";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemoveOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(txtCNIC);
            Controls.Add(label1);
            Name = "RemoveOwnerForm";
            Text = "RemoveOwnerForm";
            Load += RemoveOwnerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCNIC;
        private Button btnRemove;
    }
}