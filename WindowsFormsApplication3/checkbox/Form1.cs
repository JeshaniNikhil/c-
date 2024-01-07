using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        String text1 = "";
        String text2 = "";
        String text3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                text1 = checkBox1.Text;
            }
            else
            {
                text1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox2.Checked == true)
            {
                text2 = checkBox2.Text;
            }
            else
            {
                text2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                text3 = checkBox3.Text;
            }
            else
            {
                text3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Your Selected games:" + text1 + " " +text2 + " " + text3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true)
            {
                checkBox1.Visible = true;
                checkBox3.Visible = true;
                checkBox2.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s); 
            }
        }
    }
}
