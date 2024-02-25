using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defination1
{
    public partial class Form1 : Form
    {
        public string FileName { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OD = new OpenFileDialog();
            OD.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(OD.FileName);
            String newFileName = OD.FileName;
            FileName = newFileName.Split(new char[] { '\\' })[newFileName.Split(new char[] { '\\' }).Length - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String newpath = Application.StartupPath + "\\Images\\" + FileName;
            pictureBox1.Image.Save(newpath);
            MessageBox.Show("Image Added Succesfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
