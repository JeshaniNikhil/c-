namespace studentaddmissionform
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
            this.submit = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.ComboBox();
            this.Aadharno = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(45, 462);
            this.submit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(519, 42);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(133, 43);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(433, 34);
            this.sname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dob:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Aadhar No:";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(132, 255);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(433, 34);
            this.city.TabIndex = 12;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(131, 308);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(433, 34);
            this.address.TabIndex = 13;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 34);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(131, 141);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(91, 33);
            this.Male.TabIndex = 16;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(228, 141);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(122, 33);
            this.Female.TabIndex = 17;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // course
            // 
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "BCOM",
            "BSC",
            "BA",
            "MA",
            "MCA",
            "MSC",
            "MCOM"});
            this.course.Location = new System.Drawing.Point(131, 201);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(431, 37);
            this.course.TabIndex = 18;
            this.course.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // Aadharno
            // 
            this.Aadharno.Location = new System.Drawing.Point(133, 362);
            this.Aadharno.Name = "Aadharno";
            this.Aadharno.Size = new System.Drawing.Size(429, 34);
            this.Aadharno.TabIndex = 19;
            this.Aadharno.TextChanged += new System.EventHandler(this.Aadharno_TextChanged);
            this.Aadharno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aadharno_KeyPress);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(133, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(430, 34);
            this.id.TabIndex = 20;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "id:";
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 552);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Aadharno);
            this.Controls.Add(this.course);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.submit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.TextBox Aadharno;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
    }
}

