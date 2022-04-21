namespace CreaDiccionario
{
    public partial class CreaDiccionario : Form
    {
        private TranslatedWords translatedWords;
        private bool modified = false;

        public CreaDiccionario()
        {
            InitializeComponent();

            translatedWords = new TranslatedWords();
            List<Pair> lista = translatedWords.GetWords();

            listBoxPairs.Items.AddRange(lista.ToArray());
        }

        private void CreaDiccionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToFile();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string spanish = textBoxSpanish.Text.Trim().ToLower();
            string english = textBoxEnglish.Text.Trim().ToLower();

            if (spanish.Length != 0 && english.Length != 0)
            {
                listBoxPairs.Items.Add($"{spanish}, {english}");
                modified = true;
                textBoxSpanish.Text = "";
                textBoxEnglish.Text = "";
            }
        }
        private void ListBoxPairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxPairs.SelectedIndex;

            if (index != -1)
            {
                listBoxPairs.Items.RemoveAt(index);
                modified = true;
                btnRemove.Enabled = false;
            }
        }

        private void ToFile()
        {
            if (modified)
            {
                string[] pairs = new string[listBoxPairs.Items.Count];
                string record;

                for (int i = 0; i < pairs.Length; i++)
                {
                    record = listBoxPairs.Items[i].ToString();
                    pairs[i] = record;
                }

                translatedWords.CreateFile(pairs);
            }
        }
    }
}