namespace StudentRegistration
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
            this.components = new System.ComponentModel.Container();
            this.S_id = new System.Windows.Forms.Label();
            this.S_Name = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.TextBox();
            this.co = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // S_id
            // 
            this.S_id.AutoSize = true;
            this.S_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_id.Location = new System.Drawing.Point(71, 82);
            this.S_id.Name = "S_id";
            this.S_id.Size = new System.Drawing.Size(73, 29);
            this.S_id.TabIndex = 0;
            this.S_id.Text = "S_id:";
            // 
            // S_Name
            // 
            this.S_Name.AutoSize = true;
            this.S_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Name.Location = new System.Drawing.Point(27, 146);
            this.S_Name.Name = "S_Name";
            this.S_Name.Size = new System.Drawing.Size(120, 29);
            this.S_Name.TabIndex = 1;
            this.S_Name.Text = "S_Name:";
            this.S_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(42, 214);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(104, 29);
            this.Course.TabIndex = 2;
            this.Course.Text = "Course:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(28, 281);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(116, 29);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address:";
            // 
            // sid
            // 
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.Location = new System.Drawing.Point(156, 77);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(332, 34);
            this.sid.TabIndex = 1;
            this.sid.Leave += new System.EventHandler(this.sid_Leave);
            // 
            // sname
            // 
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.Location = new System.Drawing.Point(156, 141);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(332, 34);
            this.sname.TabIndex = 2;
            this.sname.Leave += new System.EventHandler(this.sname_Leave);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(156, 281);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(332, 98);
            this.add.TabIndex = 4;
            this.add.Leave += new System.EventHandler(this.add_Leave);
            // 
            // co
            // 
            this.co.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.co.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.co.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.co.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.FormattingEnabled = true;
            this.co.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "Bcom"});
            this.co.Location = new System.Drawing.Point(156, 206);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(335, 37);
            this.co.TabIndex = 3;
            this.co.Leave += new System.EventHandler(this.co_Leave);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(190, 412);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 50);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(341, 412);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(124, 50);
            this.New.TabIndex = 6;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 488);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.co);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.S_Name);
            this.Controls.Add(this.S_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label S_id;
        private System.Windows.Forms.Label S_Name;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.ComboBox co;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

