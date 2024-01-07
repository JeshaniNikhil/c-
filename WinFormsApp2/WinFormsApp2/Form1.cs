namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(MessageBox.Show("Exit?","App1",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if(a==6)
            {
                Application.Exit();
            }
            if (a == 7)
            {
                MessageBox.
            }
        }
    }
}