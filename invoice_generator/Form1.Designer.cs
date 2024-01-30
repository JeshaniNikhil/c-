namespace invoice_generator
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

        private void GetV()
        {
           // this.add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_KeyPress);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnm = new System.Windows.Forms.TextBox();
            this.cmo = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.quentity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Print = new System.Windows.Forms.Button();
            this.DirectPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Mobile No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // cnm
            // 
            this.cnm.Location = new System.Drawing.Point(331, 139);
            this.cnm.Name = "cnm";
            this.cnm.Size = new System.Drawing.Size(534, 34);
            this.cnm.TabIndex = 2;
            this.cnm.TextChanged += new System.EventHandler(this.cnm_TextChanged);
            this.cnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnm_KeyPress);
            this.cnm.Leave += new System.EventHandler(this.cnm_Leave);
            // 
            // cmo
            // 
            this.cmo.Location = new System.Drawing.Point(331, 194);
            this.cmo.MaxLength = 10;
            this.cmo.Name = "cmo";
            this.cmo.Size = new System.Drawing.Size(534, 34);
            this.cmo.TabIndex = 3;
            this.cmo.TextChanged += new System.EventHandler(this.cmo_TextChanged);
            this.cmo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmo_KeyPress);
            this.cmo.Leave += new System.EventHandler(this.cmo_Leave);
            // 
            // product
            // 
            this.product.FormattingEnabled = true;
            this.product.ItemHeight = 25;
            this.product.Items.AddRange(new object[] {
            "Cake",
            "Biscuit",
            "Bread",
            "Soap",
            "Wheat",
            "Rice",
            "Tuverdal",
            "Chanadal",
            "Mungdal",
            "Kaju",
            "Badam"});
            this.product.Location = new System.Drawing.Point(331, 249);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(534, 129);
            this.product.TabIndex = 4;
            this.product.SelectedIndexChanged += new System.EventHandler(this.product_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Products:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 529);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(913, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(428, 68);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quentity";
            // 
            // quentity
            // 
            this.quentity.Location = new System.Drawing.Point(331, 424);
            this.quentity.Name = "quentity";
            this.quentity.Size = new System.Drawing.Size(534, 34);
            this.quentity.TabIndex = 9;
            this.quentity.TextChanged += new System.EventHandler(this.quentity_TextChanged);
            this.quentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quentity_KeyPress);
            this.quentity.Leave += new System.EventHandler(this.quentity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(331, 479);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(534, 34);
            this.price.TabIndex = 11;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.Leave += new System.EventHandler(this.price_Leave);
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
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(913, 217);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(428, 65);
            this.Print.TabIndex = 12;
            this.Print.Text = "Save Pdf";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // DirectPrint
            // 
            this.DirectPrint.Location = new System.Drawing.Point(913, 303);
            this.DirectPrint.Name = "DirectPrint";
            this.DirectPrint.Size = new System.Drawing.Size(428, 63);
            this.DirectPrint.TabIndex = 13;
            this.DirectPrint.Text = "Print";
            this.DirectPrint.UseVisualStyleBackColor = true;
            this.DirectPrint.Click += new System.EventHandler(this.DirectPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 838);
            this.Controls.Add(this.DirectPrint);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quentity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product);
            this.Controls.Add(this.cmo);
            this.Controls.Add(this.cnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnm;
        private System.Windows.Forms.TextBox cmo;
        private System.Windows.Forms.ListBox product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quentity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button DirectPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        //private Kimtoo.Reports.ktReport ktReport1;
    }
}

