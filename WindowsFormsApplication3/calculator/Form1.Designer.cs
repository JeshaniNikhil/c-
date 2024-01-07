namespace calculator
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.value1t = new System.Windows.Forms.TextBox();
            this.value2t = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(-8, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(788, 103);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Calculator";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // value1t
            // 
            this.value1t.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value1t.Location = new System.Drawing.Point(242, 171);
            this.value1t.Name = "value1t";
            this.value1t.Size = new System.Drawing.Size(326, 34);
            this.value1t.TabIndex = 1;
            // 
            // value2t
            // 
            this.value2t.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value2t.Location = new System.Drawing.Point(242, 226);
            this.value2t.Name = "value2t";
            this.value2t.Size = new System.Drawing.Size(326, 34);
            this.value2t.TabIndex = 1;
            // 
            // value1
            // 
            this.value1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value1.AutoSize = true;
            this.value1.BackColor = System.Drawing.Color.Gold;
            this.value1.ForeColor = System.Drawing.Color.Blue;
            this.value1.Location = new System.Drawing.Point(113, 171);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(107, 29);
            this.value1.TabIndex = 2;
            this.value1.Text = "Value 1:";
            // 
            // value2
            // 
            this.value2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value2.AutoSize = true;
            this.value2.BackColor = System.Drawing.Color.Gold;
            this.value2.ForeColor = System.Drawing.Color.Blue;
            this.value2.Location = new System.Drawing.Point(113, 226);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(107, 29);
            this.value2.TabIndex = 2;
            this.value2.Text = "Value 2:";
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.Fuchsia;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.ForeColor = System.Drawing.Color.White;
            this.addition.Location = new System.Drawing.Point(242, 275);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(62, 64);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.Fuchsia;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.ForeColor = System.Drawing.Color.White;
            this.sub.Location = new System.Drawing.Point(323, 275);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(62, 64);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.Fuchsia;
            this.mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mul.ForeColor = System.Drawing.Color.White;
            this.mul.Location = new System.Drawing.Point(407, 275);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(62, 64);
            this.mul.TabIndex = 3;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.BackColor = System.Drawing.Color.Fuchsia;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.ForeColor = System.Drawing.Color.White;
            this.div.Location = new System.Drawing.Point(494, 275);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(62, 64);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(760, 483);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.value2t);
            this.Controls.Add(this.value1t);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox value1t;
        private System.Windows.Forms.TextBox value2t;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
    }
}

