namespace EmployeManagementSystem
{
    partial class empform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empform));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.destxt = new System.Windows.Forms.ComboBox();
            this.agetxt = new System.Windows.Forms.NumericUpDown();
            this.insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agetxt)).BeginInit();
            this.g.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(57, 35);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(87, 32);
            this.l1.TabIndex = 0;
            this.l1.Text = "Name:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(66, 99);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(66, 32);
            this.l2.TabIndex = 0;
            this.l2.Text = "Age:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(0, 164);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(149, 32);
            this.l3.TabIndex = 0;
            this.l3.Text = "Designation:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(36, 221);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(96, 32);
            this.l4.TabIndex = 0;
            this.l4.Text = "Salary:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(155, 27);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(416, 40);
            this.nametxt.TabIndex = 0;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            this.nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametxt_KeyPress);
            this.nametxt.Leave += new System.EventHandler(this.nametxt_Leave);
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(155, 213);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(416, 40);
            this.salarytxt.TabIndex = 3;
            this.salarytxt.TextChanged += new System.EventHandler(this.salarytxt_TextChanged);
            this.salarytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salarytxt_KeyPress);
            this.salarytxt.Leave += new System.EventHandler(this.salarytxt_Leave);
            // 
            // destxt
            // 
            this.destxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destxt.FormattingEnabled = true;
            this.destxt.Items.AddRange(new object[] {
            "Accountant",
            "Manager",
            "Computer Operator"});
            this.destxt.Location = new System.Drawing.Point(155, 156);
            this.destxt.Name = "destxt";
            this.destxt.Size = new System.Drawing.Size(416, 40);
            this.destxt.TabIndex = 2;
            this.destxt.Leave += new System.EventHandler(this.destxt_Leave);
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(155, 91);
            this.agetxt.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.agetxt.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(416, 40);
            this.agetxt.TabIndex = 1;
            this.agetxt.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.agetxt.Leave += new System.EventHandler(this.agetxt_Leave);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(577, 27);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(104, 40);
            this.insert.TabIndex = 4;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(577, 89);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 40);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(577, 155);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(104, 40);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(577, 217);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(104, 40);
            this.view.TabIndex = 7;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Registration Form";
            // 
            // g
            // 
            this.g.Controls.Add(this.agetxt);
            this.g.Controls.Add(this.l1);
            this.g.Controls.Add(this.l2);
            this.g.Controls.Add(this.view);
            this.g.Controls.Add(this.l3);
            this.g.Controls.Add(this.Delete);
            this.g.Controls.Add(this.l4);
            this.g.Controls.Add(this.Update);
            this.g.Controls.Add(this.nametxt);
            this.g.Controls.Add(this.insert);
            this.g.Controls.Add(this.salarytxt);
            this.g.Controls.Add(this.destxt);
            this.g.Location = new System.Drawing.Point(12, 58);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(704, 325);
            this.g.TabIndex = 6;
            this.g.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchtxt);
            this.groupBox1.Location = new System.Drawing.Point(54, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(536, 39);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(57, 40);
            this.searchbtn.TabIndex = 9;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(113, 39);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(416, 40);
            this.searchtxt.TabIndex = 8;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            this.searchtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 232);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 308);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // empform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 753);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.g);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "empform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.agetxt)).EndInit();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.ComboBox destxt;
        private System.Windows.Forms.NumericUpDown agetxt;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

