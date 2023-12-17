namespace Custom_Buttons
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Close = new Button();
            Max = new Button();
            Min = new Button();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.Red;
            Close.FlatStyle = FlatStyle.Flat;
            Close.ForeColor = SystemColors.ControlLightLight;
            Close.Location = new Point(1105, 13);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(69, 63);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button1_Click;
            // 
            // Max
            // 
            Max.BackColor = Color.Lime;
            Max.FlatStyle = FlatStyle.Flat;
            Max.ForeColor = SystemColors.ButtonFace;
            Max.Location = new Point(1021, 13);
            Max.Name = "Max";
            Max.Size = new Size(72, 63);
            Max.TabIndex = 1;
            Max.Text = "[]";
            Max.UseVisualStyleBackColor = false;
            Max.Click += button1_Click_1;
            // 
            // Min
            // 
            Min.BackColor = Color.Blue;
            Min.FlatStyle = FlatStyle.Flat;
            Min.ForeColor = SystemColors.ButtonFace;
            Min.Location = new Point(938, 13);
            Min.Name = "Min";
            Min.Size = new Size(75, 63);
            Min.TabIndex = 2;
            Min.Text = "-";
            Min.UseVisualStyleBackColor = false;
            Min.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1200, 630);
            Controls.Add(Min);
            Controls.Add(Max);
            Controls.Add(Close);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "login";
            WindowState = FormWindowState.Maximized;
            Load += login_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private Button Max;
        private Button Min;
    }
}
