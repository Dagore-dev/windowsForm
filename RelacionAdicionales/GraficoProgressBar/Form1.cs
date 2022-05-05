namespace GraficoProgressBar
{
    public partial class Form1 : Form
    {
        private Random r;
        private List<ProgressBar> progressBars;
        private int[] results;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            progressBars = new List<ProgressBar>
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5,
                progressBar6,
                progressBar7,
                progressBar8,
                progressBar9,
                progressBar10,
                progressBar11
            };
            results = new int[11];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string s = numericUpDown1.Value.ToString();
            int n;

            if (int.TryParse(s, out n))
            {
                for (int i = 0; i < n; i++)
                {
                    UpdateResults();
                    UpdateProgressBars();
                }
                numericUpDown1.Value = n;
            }
            else
            {
                MessageBox.Show("No se ha introducido un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateResults ()
        {
            int dice1, dice2;
            dice1 = r.Next(6);
            dice2 = r.Next(6);

            results[dice1 + dice2]++;
        }
        private void UpdateProgressBars()
        {
            int index = GetMaxIndex();

            for (int i = 0; i < progressBars.Count; i++)
            {
                progressBars[i].Maximum = results[index];
                progressBars[i].Value = results[i];
            }
        }
        private int GetMaxIndex ()
        {
            int n = int.MinValue, index = 0;

            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] > n)
                {
                    n = results[i];
                    index = i;
                }
            }

            return index;
        }
    }
}