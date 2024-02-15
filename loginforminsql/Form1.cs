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

namespace loginforminsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(unmtxt.Text!="" && passtxt.Text != "")
            {
                string sql = "select * from emplogin where unm='"+unmtxt.Text+"' AND pwd='"+passtxt.Text+"'";
                SqlDataAdapter da =new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Succesfully");
                }
                else
                {
                    MessageBox.Show("Username or passsword is incoorect");
                    unmtxt.Clear();
                    passtxt.Clear();
                }
            }
            else
            {
                MessageBox.Show("User Name Or Password is Blank");
                unmtxt.Clear();
                passtxt.Clear();
            }
        }
    }
}
