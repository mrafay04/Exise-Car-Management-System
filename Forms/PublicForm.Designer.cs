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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)lblResultordataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 23, 20, 23);
            label2.Size = new Size(269, 71);
            label2.TabIndex = 2;
            label2.Text = "Welcome To Public Portal";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 55);
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
            txtVehicleNumber.Location = new Point(393, 74);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(263, 33);
            txtVehicleNumber.TabIndex = 4;
            txtVehicleNumber.KeyDown += txtVehicleNumber_KeyDown;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(672, 421);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(103, 35);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Close";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblResultordataGridView1
            // 
            lblResultordataGridView1.BackgroundColor = Color.White;
            lblResultordataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lblResultordataGridView1.Location = new Point(170, 154);
            lblResultordataGridView1.Name = "lblResultordataGridView1";
            lblResultordataGridView1.Size = new Size(486, 77);
            lblResultordataGridView1.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Silver;
            lblResult.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(297, 234);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(20, 23, 20, 23);
            lblResult.Size = new Size(269, 71);
            lblResult.TabIndex = 7;
            lblResult.Text = "Welcome To Public Portal";
            lblResult.Click += lblResult_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(lblResultordataGridView1);
            groupBox1.Controls.Add(txtVehicleNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 585);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Public Screen";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // PublicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1100, 612);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PublicForm";
            Text = "PublicForm";
            Load += PublicForm_Load;
            ((System.ComponentModel.ISupportInitialize)lblResultordataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtVehicleNumber;
        private Button btnLogout;
        private DataGridView lblResultordataGridView1;
        private Label lblResult;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private GroupBox groupBox1;
    }
}