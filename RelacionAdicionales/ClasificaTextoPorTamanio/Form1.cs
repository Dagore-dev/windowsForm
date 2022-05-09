using System.Text;

namespace ClasificaTextoPorTamanio
{
    public partial class ClasificaTextoPorTamanio : Form
    {
        private Clasificador clasificador;
        private string[] rowLabels = new string[]
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10+"
        };
        public ClasificaTextoPorTamanio()
        {
            InitializeComponent();
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult openFile = openFileDialog1.ShowDialog();
            string path;

            if (openFile == DialogResult.OK)
            {
                listView1.Items.Clear();
                path = openFileDialog1.FileName;    
                clasificador = new Clasificador(path);
                UpdateListView(clasificador);
            }
        }
        private void UpdateListView (Clasificador clasificador)
        {
            ListViewItem item;
            string[] words;
            string commaSeparatedList;

            for (int i = 0; i < 10; i++)
            {
                words = clasificador[i].ToArray();
                commaSeparatedList = ProcessWords(words);
                item = new ListViewItem(new string[] { rowLabels[i], commaSeparatedList });
                listView1.Items.Add(item);
            }
        }
        private string ProcessWords (string[] words)
        {
            StringBuilder sb = new StringBuilder();
            int length = words.Length;

            if (length != 0)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    sb.Append($"{words[i]}, ");
                }

                sb.Append(words[length - 1]);
            }

            return sb.ToString();
        }
    }
}