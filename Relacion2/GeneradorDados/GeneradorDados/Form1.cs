namespace GeneradorDados
{
    public partial class GeneradorDados : Form
    {
        private DiceRoller diceRoller;

        public GeneradorDados()
        {
            InitializeComponent();
            diceRoller = new DiceRoller();
        }

        private void BtnRollDice_Click(object sender, EventArgs e)
        {
            int quantity = (int) numericUpDownQuantity.Value;
            int faces = (int) numericUpDownFaces.Value;
            int total = 0;
            int result;

            listBoxResults.Items.Clear();

            for (int i = 0; i < quantity; i++)
            {
                result = diceRoller.Roll(faces);
                total += result;
                listBoxResults.Items.Add(result);
            }

            textBoxTotal.Text = total.ToString();
        }
    }
}