using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updatelist
{
    public partial class update : Form
    {
        public static string text1,text2,text3;
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index=listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, textBox1.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    textBox1.Text = listBox1.SelectedItem.ToString();
                }
            }
            catch
            {
                // Handle the exception if needed
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text1 = textBox2.Text; text2=textBox3.Text; text3=textBox4.Text;
            Form2 f2 = new Form2();
            f2.Show();
           
        }
    }
}
