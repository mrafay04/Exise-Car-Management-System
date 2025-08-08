namespace CarVerification
{
    partial class PublicForm
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
            txtVehicleNumber = new TextBox();
            btnLogout = new Button();
            lblResultordataGridView1 = new DataGridView();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)lblResultordataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 23);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 23, 20, 23);
            label2.Size = new Size(269, 71);
            label2.TabIndex = 2;
            label2.Text = "Welcome To Public Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 141);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 23, 20, 23);
            label1.Size = new Size(377, 71);
            label1.TabIndex = 3;
            label1.Text = "Enter Registration Number Of Vehicle: ";
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.BackColor = Color.FromArgb(224, 224, 224);
            txtVehicleNumber.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleNumber.Location = new Point(467, 164);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(263, 33);
            txtVehicleNumber.TabIndex = 4;
            txtVehicleNumber.KeyDown += txtVehicleNumber_KeyDown;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(50, 389);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 62);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblResultordataGridView1
            // 
            lblResultordataGridView1.BackgroundColor = Color.White;
            lblResultordataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lblResultordataGridView1.Location = new Point(282, 249);
            lblResultordataGridView1.Name = "lblResultordataGridView1";
            lblResultordataGridView1.Size = new Size(486, 295);
            lblResultordataGridView1.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.FromArgb(255, 224, 192);
            lblResult.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(396, 434);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(20, 23, 20, 23);
            lblResult.Size = new Size(269, 71);
            lblResult.TabIndex = 7;
            lblResult.Text = "Welcome To Public Portal";
            // 
            // PublicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1100, 749);
            Controls.Add(lblResult);
            Controls.Add(lblResultordataGridView1);
            Controls.Add(btnLogout);
            Controls.Add(txtVehicleNumber);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PublicForm";
            Text = "PublicForm";
            ((System.ComponentModel.ISupportInitialize)lblResultordataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtVehicleNumber;
        private Button btnLogout;
        private DataGridView lblResultordataGridView1;
        private Label lblResult;
    }
}