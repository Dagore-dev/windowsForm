namespace VisualGatos
{
    public partial class VisualGatitos : Form
    {
        private string path;
        public VisualGatitos()
        {
            InitializeComponent();
            path = "gatitos.csv";

            LoadFromFile();
        }

        private void LoadFromFile ()
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
        private void WriteFile ()
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

        private void VisualGatitos_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFile();
        }
    }
}