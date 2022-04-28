namespace VisualGatos
{
    public partial class VisualGatitos : Form
    {
        private string path;
        private TextBox[] textBoxes;

        public VisualGatitos()
        {
            InitializeComponent();
            path = "gatitos.csv";
            textBoxes = new TextBox[]
            {
                textBoxName,
                textBoxColor,
                textBoxRace,
                textBoxWeight,
                textBoxSize,
                textBoxEyeColor
            };

            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(path))
            {
                CSVLoader loader = new CSVLoader(path);
                UpdateListviewFromCSV(loader.CSV);
            }
            else
            {
                MessageBox.Show($"No se ha encontrado el fichero {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WriteFile()
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < listViewDetail.Columns.Count; i++)
            {
                sw.Write(listViewDetail.Columns[i].Text + ",");
            }

            for (int i = 0; i < listViewDetail.Items.Count; i++)
            {
                sw.Write("\n");

                ListViewItem item = listViewDetail.Items[i];

                for (int j = 0; j < item.SubItems.Count; j++)
                {
                    sw.Write(item.SubItems[j].Text + ",");
                }
            }

            sw.Close();
        }
        private void UpdateColumsSize ()
        {
            listViewDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void UpdateListviewFromCSV(CSV csv)
        {
            listViewDetail.Items.Clear();
            listViewDetail.Columns.Clear();

            foreach (string columnName in csv.Columns)
            {
                listViewDetail.Columns.Add(columnName);
            }

            foreach (string[] row in csv.Rows)
            {
                ListViewItem lvi = new ListViewItem(row);
                listViewDetail.Items.Add(lvi);
            }

            UpdateColumsSize();
        }
        private void ClearFields ()
        {
            textBoxName.Clear();
            textBoxColor.Clear();
            textBoxRace.Clear();
            textBoxWeight.Clear();
            textBoxSize.Clear();
            textBoxEyeColor.Clear();
        }
        private void NewBehavior()
        {
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;

            ClearFields();

            btnSave.Enabled = true;
        }
        private void SaveBehaviour()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            listViewDetail.SelectedItems.Clear();
            ClearFields();
            UpdateColumsSize();
        }
        private void RemoveBehaviour()
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void UpdateBehaviour()
        {
            btnSave.Enabled = true;
        }

        private void VisualGatitos_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFile();
        }
        private void ListViewDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDetail.SelectedIndices.Count != 0)
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnRemove.Enabled = true;
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            listViewDetail.SelectedItems.Clear();
            NewBehavior();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Gato gato;
            ListViewItem item;
            string name = textBoxName.Text, hairColor = textBoxColor.Text, race = textBoxRace.Text, eyeColor = textBoxEyeColor.Text;
            double weight, size;
            
            if (double.TryParse(textBoxWeight.Text, out weight) && double.TryParse(textBoxSize.Text, out size))
            {
                if (name.Length != 0 && hairColor.Length != 0 && race.Length != 0 && eyeColor.Length != 0)
                {
                    gato = new Gato(name, hairColor, race, weight, size, eyeColor);
                    item = new ListViewItem(gato.Properties);

                    if (listViewDetail.SelectedIndices.Count == 0)
                    {
                        listViewDetail.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem.ListViewSubItemCollection subitems = listViewDetail.SelectedItems[0].SubItems;

                        subitems[0].Text = name;
                        subitems[1].Text = hairColor;
                        subitems[2].Text = race;
                        subitems[3].Text = String.Format("{0:0.00}", weight).Replace(',', '.');
                        subitems[4].Text = String.Format("{0:0.00}", size).Replace(',', '.');
                        subitems[5].Text = eyeColor;
                    }

                    SaveBehaviour();
                }
                else
                {
                    MessageBox.Show("Los campos son obligatorios. Si no los conones indica \"Desconocido\" o -1 para peso y tamaño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en los campos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewDetail.SelectedItems[0];
            listViewDetail.Items.Remove(item);
            
            RemoveBehaviour();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewDetail.SelectedItems[0];

            for (int i = 0; i < 6; i++)
            {
                textBoxes[i].Text = item.SubItems[i].Text;
            }

            UpdateBehaviour();
        }
    }
}