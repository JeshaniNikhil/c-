using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentregistrationformwithimageuploading
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false };
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a= (int)MessageBox.Show("Are You Sure Want To Exit?", "information", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (a == 6)
            {
                Application.Exit();
            }
        }

        
        public void insert(string fileName,byte[] image)
        {
            Class1.cn.Open();
            SqlCommand cmd= new SqlCommand("insert into [dbo].[Table](rollno,name,contact,course,address,profilephoto) values(@rollno,@name,@contact,@course,@address,@profilephoto)",Class1.cn);
            cmd.Parameters.AddWithValue("@rollno", rolltxt.Text);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.Parameters.AddWithValue("@contact", contacttxt.Text);
            cmd.Parameters.AddWithValue("@course", coursecmb.Text);
            cmd.Parameters.AddWithValue("@address", rolltxt.Text);
            cmd.Parameters.AddWithValue("@profilephoto", image);
            cmd.ExecuteNonQuery();
        }
        public void loaddata()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Table]", Class1.cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        byte[] ConvertImageToByte(Image img)
        {
            MemoryStream ms=new MemoryStream();
            img.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (IsIdUnique(rolltxt.Text))
            {
                if (contacttxt.Text.Length < 10)
                {
                    MessageBox.Show("Contact Number is not 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rolltxt.Text == "" && nametxt.Text == "" && contacttxt.Text == "" && addresstxt.Text == "")
                    {
                        MessageBox.Show("Please Fill All Fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string fname = openFileDialog.FileName;
                        insert(fname, ConvertImageToByte(pictureBoxStudent.Image));
                        MessageBox.Show("Data Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        loaddata();
                    }
                }
            }
            else
            {
                MessageBox.Show("roll no already exists. Please choose a unique roll no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            /*Image defaultImage = Properties.Resources.profileblank;
            pictureBoxStudent.Image = defaultImage;*/
            clear();
        }
        void numeric(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        void alpha(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = true;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
        public void clear()
        {
            rolltxt.Clear();
            nametxt.Clear();
            contacttxt.Clear();
            addresstxt.Clear();
            Image defaultImage = Properties.Resources.profileblank;
            pictureBoxStudent.Image = defaultImage;
        }
        private void rolltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            alpha(sender, e);
        }

        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            if (int.TryParse(searchtxt.Text, out int id))
            {
                // If the search term is numeric, perform an ID search
                string query = "SELECT * FROM [dbo].[Table] WHERE rollno = @rn";
                da = new SqlDataAdapter(query,Class1.cn);
                da.SelectCommand.Parameters.AddWithValue("@rn", searchtxt.Text);
            }
            else
            {
                string query = "SELECT * FROM [dbo].[Table] WHERE name LIKE '" + searchtxt.Text + "' + '%'";
                da = new SqlDataAdapter(query, Class1.cn);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = null;
                }
        }
        private bool IsIdUnique(string rollno)
        {
            string sql = "SELECT rollno FROM [dbo].[Table]";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow[] rows = dt.Select("rollno = '" + rollno + "'");
            return rows.Length == 0;
        }
    }
}