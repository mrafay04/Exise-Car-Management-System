namespace CarVerification
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(307, 84);
            button1.Name = "button1";
            button1.Size = new Size(139, 45);
            button1.TabIndex = 0;
            button1.Text = "Admin Portal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 173);
            button2.Name = "button2";
            button2.Size = new Size(171, 47);
            button2.TabIndex = 1;
            button2.Text = "Online Vehical Verification";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, -9);
            label1.Name = "label1";
            label1.Padding = new Padding(30);
            label1.Size = new Size(495, 90);
            label1.TabIndex = 2;
            label1.Text = "Welcome To Excise Vehicle Verification Portal";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(307, 251);
            button3.Name = "button3";
            button3.Size = new Size(139, 46);
            button3.TabIndex = 3;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(276, 144);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 11;
            label2.Text = "// Only For Government Admins // ";
            // 
            // button4
            // 
            button4.Location = new Point(649, 364);
            button4.Name = "button4";
            button4.Size = new Size(139, 47);
            button4.TabIndex = 12;
            button4.Text = "&Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
    }
}