using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlfirstprog
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\c#\\sqlfirstprog\\bin\\Debug\\login.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Table] values (@Id,@Name,@Address)", con);
            cmd.Parameters.AddWithValue("@Id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",name.Text);
            cmd.Parameters.AddWithValue("@Address",address.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [Table]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
