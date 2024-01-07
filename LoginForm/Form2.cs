using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Configuration;
namespace LoginForm
{
    public partial class Form2 : Form
    {
       
        string emailpattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        string passpattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void idtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtxt.Text) == true) 
            {
                idtxt.Focus();
                errorProvider1.SetError(this.idtxt, "Please Fill Id");
            }
            else {
                errorProvider1.Clear();
            }
        }

        private void idtxt_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void idtxt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void nametxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider2.SetError(this.nametxt, "Please Fill Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 32)
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
        private void emailtxt_Leave(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(emailtxt.Text, emailpattern)==false)
            {
                emailtxt.Focus();
                errorProvider3.SetError(this.emailtxt, "Please Fill Correct Email");

            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(passtxt.Text, passpattern) == false)
            {
                passtxt.Focus();
                errorProvider4.SetError(this.passtxt, "Please Enter Strong Password With min 8 max 15 character, One Special Character @,! One Number 123, One Lowecase a b c and One Uppercase A B");
            }
            else
            {
                errorProvider4.Clear();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                passtxt.UseSystemPasswordChar = false;
                cpasstxt.UseSystemPasswordChar=false;
            }
            else
            {
                passtxt.UseSystemPasswordChar = true;
                cpasstxt.UseSystemPasswordChar = true;
            }
        }
        private void cpasstxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == cpasstxt.Text)
            {
                errorProvider5.Clear();
            }
            else
            {
                cpasstxt.Focus();
                errorProvider5.SetError(this.cpasstxt, "Password And Confirm Password Not Matched");
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtxt.Text) == true)
            {
                idtxt.Focus();
                errorProvider1.SetError(this.idtxt, "Please Fill Id");
            }
            else if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider2.SetError(this.nametxt, "Please Fill Name");
            }
            else if (Regex.IsMatch(emailtxt.Text, emailpattern) == false)
            {
                emailtxt.Focus();
                errorProvider3.SetError(this.emailtxt, "Please Fill Correct Email");

            }
            else if(Regex.IsMatch(passtxt.Text, passpattern) == false)
            {
                passtxt.Focus();
                errorProvider4.SetError(this.passtxt, "Please Enter Strong Password With min 8 max 15 character, One Special Character @,! One Number 123, One Lowecase a b c and One Uppercase A B");
            }
            else if(passtxt.Text != cpasstxt.Text)
            {
                cpasstxt.Focus();
                errorProvider5.SetError(this.cpasstxt, "Password And Confirm Password Not Matched");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query3 = "select * from signup where id=@id";
                OleDbCommand cmd1=new OleDbCommand(query3,con);
                cmd1.Parameters.AddWithValue("@id", idtxt.Text);
                OleDbDataReader dr=cmd1.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show(idtxt.Text + " ID Already Exist!!");
                }
                else
                {
                    string query2 = "insert into login values(@user,@pass)";
                    OleDbCommand cmd3 = new OleDbCommand(query2, con);
                    cmd3.Parameters.AddWithValue("@user", emailtxt.Text);
                    cmd3.Parameters.AddWithValue("@pass", passtxt.Text);
                    cmd3.ExecuteNonQuery();

                    string query = "insert into signup values (@id,@name,@class,@email,@pass)";
                    OleDbCommand cmd2 = new OleDbCommand(query, con);
                    cmd2.Parameters.AddWithValue("@id", idtxt.Text);
                    cmd2.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd2.Parameters.AddWithValue("@class", classnum.Value);
                    cmd2.Parameters.AddWithValue("@email", emailtxt.Text);
                    cmd2.Parameters.AddWithValue("@pass", passtxt.Text);
                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Register Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int b=(int)(MessageBox.Show("Login Now", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (b == 6)
                        {
                            Form1 obj=new Form1();
                            obj.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Register Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }
    }
}