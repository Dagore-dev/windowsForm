namespace Quinieleitor3000
{
    public partial class Quinieleitor : Form
    {
        private List<string> partidos;
        Random random;
        public Quinieleitor()
        {
            InitializeComponent();
            
            random = new Random();
            partidos = new List<string>();
            LoadJornada(1);
            ShowPartidos();
        }

        private void LoadJornada (int jornada)
        {
            string path = $"jornada{jornada}.txt";

            if (File.Exists(path))
            {
                ReadFile(path);
            }
            else
            {
                MessageBox.Show("No se encuentra el fichero con los emparejamientos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> temp = new List<string>();
            string local, visitante;

            try
            {
                while (!sr.EndOfStream)
                {
                    local = sr.ReadLine();
                    visitante = sr.ReadLine();

                    temp.Add($"{local} - {visitante}");
                }

                partidos.AddRange(temp);
            }   
            catch
            {
                MessageBox.Show("El fichero de emparejamientos está mal formado. No se ha agregado ningún partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sr.Close();
        }
        private void ShowPartidos()
        {
            listView1.Items.Clear();

            foreach (string partido in partidos)
            {
                listView1.Items.Add(new ListViewItem(new string[] { partido }));
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void Generador ()
        {
            int r;

            foreach (ListViewItem item in listView1.Items)
            {
                r = random.Next(1, 7);
                ClearRow(item);

                if (r < 4)
                {
                    item.SubItems.Add("X");
                }
                else if (r < 6)
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("X");
                }
                else
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("X");
                }

            }
        }
        private void ClearRow(ListViewItem item)
        {
            while (item.SubItems.Count > 1)
            {
                item.SubItems.RemoveAt(item.SubItems.Count - 1);
            }
        }

        //EVENTOS
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            partidos.Clear();
            LoadJornada((int)numericUpDown1.Value);
            ShowPartidos();
        }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Generador();
        }
    }
}