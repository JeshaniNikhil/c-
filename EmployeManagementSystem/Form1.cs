using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
namespace EmployeManagementSystem
{
    public partial class empform : Form
    {
       public string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public empform()
        {
            InitializeComponent();
        }
        void reset()
        {
            nametxt.Clear();
            agetxt.Value = 1;
            destxt.Text = null;
            salarytxt.Clear();
            nametxt.Focus();
        }
        private void insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider1.SetError(this.nametxt, "Please Fill Name");
            }
            else if (string.IsNullOrEmpty(agetxt.Text) == true)
            {
                agetxt.Focus();
                errorProvider2.SetError(this.agetxt, "Please Fill age");
            }
            else if (string.IsNullOrEmpty(destxt.Text) == true)
            {
                destxt.Focus();
                errorProvider3.SetError(this.destxt, "Please Fill Designation");
            }
            else if (string.IsNullOrEmpty(salarytxt.Text) == true)
            {
                salarytxt.Focus();
                errorProvider4.SetError(this.salarytxt, "Please Fill salary");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();

                string query = "INSERT INTO emp (empname, age, designation, salary) VALUES (@empname, @age, @designation, @salary)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@empname", nametxt.Text);
                cmd.Parameters.AddWithValue("@age", agetxt.Value);
                cmd.Parameters.AddWithValue("@designation", destxt.Text);
                cmd.Parameters.AddWithValue("@salary", salarytxt.Text);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    display();
                }
                else
                {
                    MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
           
        }
        void display()
        {
            OleDbConnection connection = new OleDbConnection(cs);
            string query = "select * from emp";
            OleDbDataAdapter da=new OleDbDataAdapter(query, connection);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void view_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            agetxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            destxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            salarytxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider1.SetError(this.nametxt, "Please Fill Name");
            }
            else if (string.IsNullOrEmpty(agetxt.Text) == true)
            {
                agetxt.Focus();
                errorProvider2.SetError(this.agetxt, "Please Fill age");
            }
            else if (string.IsNullOrEmpty(destxt.Text) == true)
            {
                destxt.Focus();
                errorProvider3.SetError(this.destxt, "Please Fill Designation");
            }
            else if (string.IsNullOrEmpty(salarytxt.Text) == true)
            {
                salarytxt.Focus();
                errorProvider4.SetError(this.salarytxt, "Please Fill salary");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();

                string query = "update emp set empname=@empname, age=@age, designation=@designation, salary=@salary where empid=@empid";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@empname", nametxt.Text);
                cmd.Parameters.AddWithValue("@age", agetxt.Value);
                cmd.Parameters.AddWithValue("@designation", destxt.Text);
                cmd.Parameters.AddWithValue("@salary", salarytxt.Text);
                cmd.Parameters.AddWithValue("@empid", dataGridView1.SelectedRows[0].Cells[0].Value); // Assuming the first column is the ID

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Record Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    display();
                }
                else
                {
                    MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider1.SetError(this.nametxt, "Please Fill Name");
            }
            else if (string.IsNullOrEmpty(agetxt.Text) == true)
            {
                agetxt.Focus();
                errorProvider2.SetError(this.agetxt, "Please Fill age");
            }
            else if (string.IsNullOrEmpty(destxt.Text) == true)
            {
                destxt.Focus();
                errorProvider3.SetError(this.destxt, "Please Fill Designation");
            }
            else if (string.IsNullOrEmpty(salarytxt.Text) == true)
            {
                salarytxt.Focus();
                errorProvider4.SetError(this.salarytxt, "Please Fill salary");
            }
            else
            {
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();

                string query = "delete from emp where empid=@empid";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@empname", nametxt.Text);
                cmd.Parameters.AddWithValue("@age", agetxt.Value);
                cmd.Parameters.AddWithValue("@designation", destxt.Text);
                cmd.Parameters.AddWithValue("@salary", salarytxt.Text);
                cmd.Parameters.AddWithValue("@empid", dataGridView1.SelectedRows[0].Cells[0].Value); // Assuming the first column is the ID

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Record Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    display();
                }
                else
                {
                    MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void nametxt_Leave(object sender, EventArgs e)
        {
           
        }

        private void agetxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(agetxt.Text) == true)
            {
                agetxt.Focus();
                errorProvider2.SetError(this.agetxt, "Please Fill age");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void destxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(destxt.Text) == true)
            {
                destxt.Focus();
                errorProvider3.SetError(this.destxt, "Please Fill Designation");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void salarytxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(salarytxt.Text) == true)
            {
                salarytxt.Focus();
                errorProvider4.SetError(this.salarytxt, "Please Fill Salary");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchtxt.Text) == true)
            {
                agetxt.Focus();
                errorProvider5.SetError(this.searchtxt, "Please Fill Searchbar");
            }
            else
            {
                errorProvider5.Clear();
            }
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            // Check if the search term is numeric to determine whether it's an ID search
            string query;
            OleDbDataAdapter da;

            if (int.TryParse(searchtxt.Text, out int id))
            {
                // If the search term is numeric, perform an ID search
                query = "SELECT * FROM emp WHERE id = @id";
                da = new OleDbDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", id);
            }
            else
            {
                // If the search term is not numeric, perform a name search
                query = "SELECT * FROM emp WHERE empname LIKE @empname + '%'";
                da = new OleDbDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@empname", searchtxt.Text);
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

            con.Close();
        }

        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            // Check if the search term is numeric to determine whether it's an ID search
            string query;
            OleDbDataAdapter da;

            if (int.TryParse(searchtxt.Text, out int id))
            {
                // If the search term is numeric, perform an ID search
                query = "SELECT * FROM emp WHERE id = @id";
                da = new OleDbDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", id);
            }
            else
            {
                // If the search term is not numeric, perform a name search
                query = "SELECT * FROM emp WHERE empname LIKE @empname + '%'";
                da = new OleDbDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@empname", searchtxt.Text);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            con.Close();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch=e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if(ch==8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void salarytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salarytxt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
