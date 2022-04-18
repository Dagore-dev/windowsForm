namespace TraductorInglesEspanol
{
    public partial class Form1 : Form
    {
        private TranslatedWords tw;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tw = new TranslatedWords();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnToSpanish_Click(object sender, EventArgs e)
        {
            int index = tw.EnglishIndexOf(textBox1.Text);
            
            if (index != -1)
            {
                string translation = tw.GetSpanishWordAt(index);
                label1.Text = translation;
            }
            else
            {
                MessageBox.Show("No se ha encontrado la palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnToEnglish_Click(object sender, EventArgs e)
        {
            int index = tw.SpanishIndexOf(textBox1.Text);

            if (index != -1)
            {
                string translation = tw.GetEnglishWordAt(index);
                label1.Text = translation;
            }
            else
            {
                MessageBox.Show("No se ha encontrado la palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}