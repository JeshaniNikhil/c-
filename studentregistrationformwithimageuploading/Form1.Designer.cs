namespace studentregistrationformwithimageuploading
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rolltxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.coursecmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.pictureBoxStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 891);
            this.panel1.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(125, 489);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(199, 69);
            this.browse.TabIndex = 1;
            this.browse.Text = "Upload";
            this.browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Transparent;
            this.clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(125, 678);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(199, 69);
            this.clearbtn.TabIndex = 1;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(125, 584);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(199, 69);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.BackColor = System.Drawing.Color.White;
            this.pictureBoxStudent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudent.Image")));
            this.pictureBoxStudent.Location = new System.Drawing.Point(125, 227);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(199, 218);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 0;
            this.pictureBoxStudent.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roll No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // rolltxt
            // 
            this.rolltxt.Location = new System.Drawing.Point(642, 131);
            this.rolltxt.Name = "rolltxt";
            this.rolltxt.Size = new System.Drawing.Size(494, 34);
            this.rolltxt.TabIndex = 7;
            this.rolltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolltxt_KeyPress);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(642, 195);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(494, 34);
            this.nametxt.TabIndex = 8;
            this.nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametxt_KeyPress);
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(642, 259);
            this.contacttxt.MaxLength = 10;
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(494, 34);
            this.contacttxt.TabIndex = 9;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttxt_KeyPress);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(642, 392);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(494, 134);
            this.addresstxt.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(449, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 53);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(775, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coursecmb
            // 
            this.coursecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursecmb.FormattingEnabled = true;
            this.coursecmb.Items.AddRange(new object[] {
            "B.c.a",
            "B.B.A",
            "B.com",
            "B.ed",
            "B.a",
            "M.c.a",
            "pgdca",
            "M.com",
            "M.B.A"});
            this.coursecmb.Location = new System.Drawing.Point(642, 320);
            this.coursecmb.Name = "coursecmb";
            this.coursecmb.Size = new System.Drawing.Size(494, 37);
            this.coursecmb.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 584);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 307);
            this.dataGridView1.TabIndex = 15;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(642, 540);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(494, 34);
            this.searchtxt.TabIndex = 16;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search:";
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(1142, 540);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(66, 34);
            this.searchbtn.TabIndex = 18;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(595, 67);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student registration Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 891);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.coursecmb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.rolltxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rolltxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox coursecmb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label7;
    }
}

