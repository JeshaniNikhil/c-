using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class login : Form
    {
        int h,w;
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                resize();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                resize();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)MessageBox.Show("Do you Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == 6)
            {
                Application.Exit();
            }
        }
        private void login_Load(object sender, EventArgs e)
        {
            resize();
            h = this.Height;
            w = this.Width;
        }
        private void resize()
        {
            button1.Location = new Point(this.Width - 60, 0);
            button2.Location = new Point(this.Width - 120, 0);
            Min.Location = new Point(this.Width - 180, 0);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}