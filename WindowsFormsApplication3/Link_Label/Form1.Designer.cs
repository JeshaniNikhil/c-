namespace Link_Label
{
    partial class linklabel
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
            this.Help = new System.Windows.Forms.LinkLabel();
            this.Google = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.BackColor = System.Drawing.Color.Fuchsia;
            this.Help.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Help.ForeColor = System.Drawing.Color.Red;
            this.Help.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Help.LinkColor = System.Drawing.Color.Blue;
            this.Help.Location = new System.Drawing.Point(104, 212);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(79, 34);
            this.Help.TabIndex = 0;
            this.Help.TabStop = true;
            this.Help.Text = "Help";
            this.Help.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Help_LinkClicked);
            // 
            // Google
            // 
            this.Google.AutoSize = true;
            this.Google.BackColor = System.Drawing.Color.Fuchsia;
            this.Google.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Google.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Google.Location = new System.Drawing.Point(375, 212);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(115, 34);
            this.Google.TabIndex = 1;
            this.Google.TabStop = true;
            this.Google.Text = "Google";
            this.Google.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Google_LinkClicked);
            // 
            // linklabel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 603);
            this.Controls.Add(this.Google);
            this.Controls.Add(this.Help);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "linklabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link_Label";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.linklabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Help;
        private System.Windows.Forms.LinkLabel Google;
    }
}

