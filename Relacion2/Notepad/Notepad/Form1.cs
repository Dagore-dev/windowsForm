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
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult messageBox, saveFile;

            if (modified)
            {
                messageBox = MessageBox.Show("Parece que hay cambios sin guardar en el documento. ¿Quiere guardar los cambios?", "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (messageBox != DialogResult.Cancel)
                {
                    if (messageBox == DialogResult.Yes)
                    {
                        if (currentPath != null)
                        {
                            saveFile = SaveFile(currentPath);
                        }
                        else
                        {
                            saveFile = SaveFile();
                        }
                        if (saveFile != DialogResult.OK)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            HaveBeenModified();
        }

        #region Archivo
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
        private DialogResult SaveFile()
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

            return saveFile;
        }
        private DialogResult SaveFile (string path)
        {
            FileManager.SaveTextFile(path, textBox1.Lines);
            Text = Path.GetFileName(path);
            NoChanges();
            return DialogResult.OK;
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
                        if (currentPath != null)
                        {
                            SaveFile(currentPath);
                        }
                        else
                        {
                            SaveFile();
                        }
                    }

                    OpenFile();
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
        #endregion
        #region Edicion
        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
        private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void HoraYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            textBox1.Paste(date);
        }
        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            }
        }
        #endregion
        #region Formato
        private void FuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fontChange = fontDialog1.ShowDialog();

            if (fontChange == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.DeselectAll();
            }
        }
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult colorChange = colorDialog1.ShowDialog();

            if (colorChange == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                textBox1.DeselectAll();
            }
        }
        private void AjusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ajusteDeLinea = (ToolStripMenuItem)sender;
            if (textBox1.WordWrap)
            {
                textBox1.WordWrap = false;
                ajusteDeLinea.Checked = false;
            }
            else
            {
                textBox1.WordWrap = true;
                ajusteDeLinea.Checked = true;
            }
        }
        #endregion

    }
}