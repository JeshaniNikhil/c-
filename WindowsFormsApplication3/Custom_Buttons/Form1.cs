namespace Custom_Buttons
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)MessageBox.Show("Do You Want To Exit?", "Bt1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == 6)
            {
                Application.Exit();
            }
        }

        private void login_Load(object sender, EventArgs e)
        { 
            resize();
        }
        private void resize()
        {
            Close.Location = new(this.Width - 80,0);
            Max.Location = new(this.Width - 150,0);
            Min.Location = new(this.Width - 200,0);
            this.StartPosition= FormStartPosition.CenterScreen;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(this.WindowState== FormWindowState.Normal)
            {
                this.WindowState= FormWindowState.Maximized;
                resize();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                resize();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
