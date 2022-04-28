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

                sw.Write(item.Text + ",");

                for (int j = 0; j < item.SubItems.Count; j++)
                {
                    sw.Write(item.SubItems[j].Text + ",");
                }
            }

            sw.Close();
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

            listViewDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void NewBehavior()
        {
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;

            textBoxName.Clear();
            textBoxColor.Clear();
            textBoxRace.Clear();
            textBoxWeight.Clear();
            textBoxSize.Clear();
            textBoxEyeColor.Clear();

            btnSave.Enabled = true;
        }
        private void SaveBehaviour()
        {
            btnSave.Enabled = false;
            listViewDetail.SelectedItems.Clear();
        }
        private void RemoveBehaviour()
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public void UpdateBehaviour()
        {
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
        }

        private void VisualGatitos_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFile();
        }
        private void ListViewDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnRemove.Enabled = true;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewBehavior();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Gato gato;
            ListViewItem item;
            double weight, size;
            
            if (double.TryParse(textBoxWeight.Text, out weight) && double.TryParse(textBoxSize.Text, out size))
            {
                //ESTO NO ESTÁ FUNCIONANDO.
                gato = new Gato(textBoxName.Text, textBoxColor.Text, textBoxRace.Text, weight, size, textBoxEyeColor.Text);
                item = new ListViewItem(gato.Properties);
                listViewDetail.Items.Add(item);

                SaveBehaviour();
            }
            

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
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