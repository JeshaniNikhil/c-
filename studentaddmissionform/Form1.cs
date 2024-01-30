using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentaddmissionform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aadharno_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string Gender = string.Empty.ToString();
            if (Male.Checked == true)
            {
                Gender = "M";
            }
            else
            {
                Gender = "F";
            }
            string sql = "insert into student values('"+id.Text.ToString()+"','"+sname.Text.ToString()+"','"+dateTimePicker1.Text.ToString()+"','"+Gender.ToString()+"','"+course.Text.ToString()+"','"+city.Text.ToString()+"','"+address.Text.ToString()+"','"+Aadharno.Text.ToString()+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)==true) {
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

        private void Aadharno_KeyPress(object sender, KeyPressEventArgs e)
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
            if (Aadharno.Text.Length > 12)
            {
                 Aadharno.ForeColor = Color.Green;
            }
            else
            {
                Aadharno.ForeColor=Color.Red;
            }
        }
    }
}