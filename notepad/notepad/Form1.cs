using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            DialogResult d = new DialogResult();
            if (richTextBox1.Text != "")
            {
                d = MessageBox.Show("Save File", "Save File???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    richTextBox1.Clear();
                }
                else
                {
                    richTextBox1.Clear();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
           
                d = MessageBox.Show("Save File", "Save File???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                }
                else
                {
                    OpenFileDialog theDialog = new OpenFileDialog();
                    if (theDialog.ShowDialog() == DialogResult.OK)
                    {
                    StreamReader sr = new StreamReader(theDialog.FileName);
                    string str = sr.ReadToEnd();
                    sr.Close();
                    richTextBox1.Text = str;
                    }
                }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            if (richTextBox1.Text != "")
            {
                d = MessageBox.Show("Save File", "Save File???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    richTextBox1.Visible = false;
                }
                
            }
            else
            {
                richTextBox1.Visible=false;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog back = new ColorDialog();
            back.ShowDialog();
            richTextBox1.BackColor = back.Color;
        }
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog forcol = new ColorDialog();
            forcol.ShowDialog();
            richTextBox1.ForeColor = forcol.Color;
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fonts =new FontDialog();
            fonts.ShowDialog();
            richTextBox1.Font= fonts.Font;
        }
    }
}
