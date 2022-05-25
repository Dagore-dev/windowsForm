namespace Ej4
{
    public partial class EditorTxt : Form
    {
        Dictionary<string, long> currentFiles;
        public EditorTxt()
        {
            InitializeComponent();
            
            currentFiles = new Dictionary<string, long>();
            LoadFiles();
            UpdateListView();
        }

        private void LoadFiles()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            List<string> allFiles = new List<string>(Directory.GetFiles(currentDirectory));
            List<string> txtFiles = allFiles.FindAll(path => path.EndsWith(".txt"));
            FileInfo fileInfo;

            foreach (string file in txtFiles)
            {
                fileInfo = new FileInfo(file);
                currentFiles.Add(fileInfo.Name, fileInfo.Length);
            }
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (KeyValuePair<string, long> pair in currentFiles)
            {
                string[] line = new string[] { pair.Key, pair.Value.ToString("N0") };
                listView1.Items.Add(new ListViewItem(line));
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void OpenFile ()
        {
            string path;

            if (listView1.SelectedItems.Count > 0)
            {
                path = listView1.SelectedItems[0].Text;

                if (File.Exists(path))
                {
                    SimpleBlog simpleBlog = new SimpleBlog(path);
                    simpleBlog.ShowDialog();

                    currentFiles.Clear();
                    LoadFiles();
                    UpdateListView();
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error. No se encuentra el fichero {path}");
                }
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void ListView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                OpenFile();
            }
        }

    }
}