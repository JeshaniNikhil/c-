using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxtesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> checkedValues = new List<string>();

            // Iterate through all checkboxes on the form
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    // Add the text of the checked checkbox to the list
                    checkedValues.Add(checkbox.Text);
                }
            }

            // Create a comma-separated string from the list
            string result = string.Join(", ", checkedValues);

            // Display the result (you can use it as needed, e.g., show in a MessageBox)
            MessageBox.Show(result, "Checked Values");
        }
    }
}
