namespace ExplicacionBlogDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Opción1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Text = Path.GetFileName(path);

                StreamReader sr = new StreamReader(path);

                label1.Text = sr.ReadToEnd();

                sr.Close();
            }
        }

        private void Opción3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void opción4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}