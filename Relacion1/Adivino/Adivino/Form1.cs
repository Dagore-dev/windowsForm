namespace Adivino
{
    public partial class Form1 : Form
    {
        Game game;
        
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void BtnCorrectNumber_Click(object sender, EventArgs e)
        {
            string msg = $"Tu número es {game.Number}. He necesitado un total de {game.Tries} intentos.";
            
            MessageBox.Show(msg, "Juego completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelGuessedNumber.Text = msg;
            
            btnHigher.Enabled = false;
            btnLower.Enabled = false;
            btnCorrectNumber.Enabled = false;
        }
        private void NewGame ()
        {
            game = new Game ();
            labelGuessedNumber.Text = $"¿Es su número {game.Number}?";

            btnHigher.Enabled = true;
            btnLower.Enabled = true;
            btnCorrectNumber.Enabled = true;
        }

        private void btnHigher_Click(object sender, EventArgs e)
        {
            game.Min = game.Number;
            game.NextGuessing();
            labelGuessedNumber.Text = $"¿Es su número {game.Number}?";
            
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            game.Max = game.Number;
            game.NextGuessing();
            labelGuessedNumber.Text = $"¿Es su número {game.Number}?";
        }
    }
}