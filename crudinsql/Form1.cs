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

namespace crudinsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unmtxt.Text))
            {
                MessageBox.Show("Please Fill Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(pwdtxt.Text))
            {
                MessageBox.Show("Please Fill Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\git\\c-sharp\\crudinsql\\bin\\Debug\\Database1.mdf;Integrated Security=True");
                string sql = "SELECT * FROM [EMP_LOGIN]  WHERE username='" + unmtxt.Text + "' AND password='" + pwdtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username Or Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void unmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            alpha(sender, e);
        }
        public void alpha(object sender, KeyPressEventArgs e)
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
    }
}
