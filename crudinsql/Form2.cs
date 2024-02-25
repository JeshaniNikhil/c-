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
    public partial class Form2 : Form
    {
      SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\git\\c-sharp\\crudinsql\\bin\\Debug\\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            viewfunc();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                if (IsIdUnique(id.Text))
                {
                    string sql = "insert into EMP_DETAILS values('" + id.Text + "','" + dept.Text + "','" + name.Text + "','" + date.Text + "','" + salary.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Data Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewfunc();
                }
                else
                {
                    MessageBox.Show("ID already exists. Please choose a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            viewfunc();
        }
        void viewfunc()
        {
            string sql = "select * from EMP_DETAILS";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                string sql = "delete from EMP_DETAILS where empid='" + id.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Data Removed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewfunc();
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dept.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            date.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            salary.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                string sql = "update EMP_DETAILS set empid='" + id.Text + "',empdept='" + dept.Text + "',empname='" + name.Text + "',joindate='" + date.Text + "',salary='" + salary.Text + "' where empid='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("data upadated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewfunc();
            }
        }
        private bool IsIdUnique(string empId)
        {
            string sql = "SELECT empid FROM EMP_DETAILS";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow[] rows = dt.Select("empid = '" + empId + "'");
            return rows.Length == 0;
        }
      
       private bool Notnullfunc()
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("ID is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Name is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(dept.Text))
            {
                MessageBox.Show("department is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(salary.Text))
            {
                MessageBox.Show("salary is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
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
        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            alpha(sender, e);
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeric(sender, e);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
