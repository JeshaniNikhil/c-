using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sid.Text))
            {
                sid.Focus();
                errorProvider1.SetError(this.sid, "Please Fill Student id");
            }
            else if (string.IsNullOrEmpty(sname.Text))
            {
                sname.Focus();
                errorProvider2.SetError(this.sname, "Please Fill Student Name");
            }
            else if (co.SelectedItem == null)
            {
                co.Focus();
                errorProvider3.SetError(this.co, "Please Fill Student Course");
            }
            else if (string.IsNullOrEmpty(add.Text))
            {
                add.Focus();
                errorProvider4.SetError(this.add, "Please Fill Address");
            }
            else
            {
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query2 = "select * from studentinfo where s_id=@s_id";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                cmd2.Parameters.AddWithValue("@s_id", sid.Text);
                OleDbDataReader reader = cmd2.ExecuteReader();
                if (reader.HasRows == true)
                {
                    MessageBox.Show(sid.Text + "Id Already Exists !");
                }
                else
                {
                    string query = "insert into studentinfo values(@s_id,@s_name,@course,@address)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@s_id", sid.Text);
                    cmd.Parameters.AddWithValue("@s_name", sname.Text);
                    cmd.Parameters.AddWithValue("@course", co.Text);
                    cmd.Parameters.AddWithValue("@address", add.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int a = (int)MessageBox.Show("Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a == 1)
                    {
                        sid.Clear();
                        sname.Clear();
                        co.Text = "";
                        add.Clear();
                        sid.Focus();
                    }
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            sid.Clear();
            sname.Clear();
            co.Text = "";
            add.Clear();
            sid.Focus();
        }

        private void sid_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(sid.Text))
            {
                sid.Focus();
                errorProvider1.SetError(this.sid, "Please Fill Student id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void sname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sname.Text))
            {
                sname.Focus();
                errorProvider2.SetError(this.sname, "Please Fill Student Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void co_Leave(object sender, EventArgs e)
        {
            if (co.SelectedItem==null)
            {
                co.Focus();
                errorProvider3.SetError(this.co, "Please Fill Student Course");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void add_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(add.Text))
            {
                add.Focus();
                errorProvider4.SetError(this.add, "Please Fill Address");
            }
            else
            {
                errorProvider4.Clear();
            }
        }
    }
}