using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            int a = int.Parse(value1t.Text);
            int b = int.Parse(value2t.Text);
            int c = a + b;
            MessageBox.Show("Addition is "+c.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            int a = int.Parse(value1t.Text);
            int b = int.Parse(value2t.Text);
            int c = a - b;
            MessageBox.Show("Substraction is " + c.ToString());
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(value1t.Text);
            int b = int.Parse(value2t.Text);
            int c = a * b;
            MessageBox.Show("Multiplication is " + c.ToString());
        }

        private void div_Click(object sender, EventArgs e)
        {
            int a = int.Parse(value1t.Text);
            int b = int.Parse(value2t.Text);
            int c = a / b;
            MessageBox.Show("Division is " + c.ToString());
        }
    }
}
