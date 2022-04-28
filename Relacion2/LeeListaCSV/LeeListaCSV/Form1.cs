namespace LeeListaCSV
{
    public partial class LeeListaCSV : Form
    {
        private CSV csv;
        public LeeListaCSV()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text.Trim();

            if (File.Exists(path))
            {
                CSVLoader loader = new CSVLoader(path);
                csv = loader.CSV;

                UpdateListviewFromCSV(csv);
            }
            else
            {
                MessageBox.Show($"No se ha encontrado el fichero {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListviewFromCSV (CSV csv)
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
    }
}