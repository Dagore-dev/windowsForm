namespace Notepad
{
    public partial class Notepad : Form
    {
        private bool modified;
        private string? currentPath;
        public Notepad()
        {
            InitializeComponent();
            NoChanges();
        }

        private void HaveBeenModified ()
        {
            modified = true;
            statusStrip1.Items[0].Text = "Fichero modificado";
        }
        private void NoChanges()
        {
            modified = false;
            statusStrip1.Items[0].Text = "No hay cambios sin guardar";
        }
        private void OpenFile()
        {
            DialogResult openFile = openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            if (openFile == DialogResult.OK && File.Exists(path))
            {
                textBox1.Lines = FileManager.LoadTextFile(path);
                currentPath = path;
                Text = Path.GetFileName(path);
                NoChanges();
            }
        }
        private void SaveFile()
        {
            DialogResult saveFile = saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;

            if (saveFile == DialogResult.OK)
            {
                FileManager.SaveTextFile(path, textBox1.Lines);
                currentPath = path;
                Text = Path.GetFileName(path);
                NoChanges();
            }
        }
        private void SaveFile (string path)
        {
            FileManager.SaveTextFile(path, textBox1.Lines);
            Text = Path.GetFileName(path);
            NoChanges();
        }
        private void NewFile()
        {
            Text = "Blog de notas";
            currentPath = null;
            textBox1.Text = "";
            NoChanges();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult messageBox;

            if (modified)
            {
                messageBox = MessageBox.Show("Parece que hay cambios sin guardar en el documento. ¿Quiere guardar los cambios?", "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (messageBox != DialogResult.Cancel)
                {
                    if (messageBox == DialogResult.Yes)
                    {
                        SaveFile();
                        OpenFile();
                    }
                    else
                    {
                        OpenFile();
                    }
                }
            }
            else
            {
                OpenFile();
            }
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult messageBox;

            if (modified)
            {
                messageBox = MessageBox.Show("Parece que hay cambios sin guardar en el documento. ¿Quiere guardar los cambios?", "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (messageBox != DialogResult.Cancel)
                {
                    if (messageBox == DialogResult.Yes)
                    {
                        SaveFile();
                        NewFile();
                    }
                    else
                    {
                        NewFile();
                    }
                }
            }
            else
            {
                NewFile();
            }
        }
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentPath != null)
            {
                SaveFile(currentPath);
            }
            else
            {
                SaveFile();
            }

            NoChanges();
        }
        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            HaveBeenModified();
        }
    }
}