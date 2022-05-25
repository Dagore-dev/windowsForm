using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej4
{
    public partial class SimpleBlog : Form
    {
        private bool changed;
        public SimpleBlog()
        {
            InitializeComponent();
            changed = false;
        }

        public SimpleBlog(string path) : this()
        {
            ReadFile(path);
            Text = path;
            changed = false;
        }

        private void ReadFile(string path)
        {
            textBox1.Lines = FileManager.LoadTextFile(path);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.SaveTextFile(Text, textBox1.Lines);
            changed = false;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }
        private void SimpleBlog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                DialogResult dr = MessageBox.Show("¿Quiere guardar los cambios?", "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    FileManager.SaveTextFile(Text, textBox1.Lines);
                }

                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
