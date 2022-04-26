namespace GeneradorTitulosPeliculas
{
    public partial class GeneradorTitulosPeliculas : Form
    {
        private string nounsPath = "nombres.txt";
        private string adjetivesPath = "adjetivos.txt";
        private Random r;
        private List<string> nouns;
        private List<string> adjetives;

        public GeneradorTitulosPeliculas()
        {
            InitializeComponent();
        }
        private void DisplayMovie ()
        {
            string s1 = comboBox1.Text;
            string s2 = comboBox2.Text;

            if (!string.IsNullOrEmpty(s1) && !string.IsNullOrEmpty(s2))
            {
                labelPelicula.Text = $"{s1} {s2}";
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            DisplayMovie();
        }
        private void BtnRandom_Click(object sender, EventArgs e)
        {
            int r1 = r.Next(0, comboBox1.Items.Count);
            int r2 = r.Next(0, comboBox2.Items.Count);

            comboBox1.SelectedItem = comboBox1.Items[r1];
            comboBox2.SelectedItem = comboBox2.Items[r2];

            DisplayMovie();
        }
        private void GeneradorTitulosPeliculas_Load(object sender, EventArgs e)
        {
            string msg;

            if (File.Exists(nounsPath) && File.Exists(adjetivesPath))
            {
                r = new Random();
                nouns = new FileReader(nounsPath).items;
                adjetives = new FileReader(adjetivesPath).items;

                comboBox1.Items.AddRange(nouns.ToArray());
                comboBox2.Items.AddRange(adjetives.ToArray());
            }
            else
            {
                msg = $"No se han encontrado los ficheros {nounsPath} y/o {adjetivesPath}";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}