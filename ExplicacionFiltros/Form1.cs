namespace ExplicacionFiltros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char c = e.KeyChar;
            //e.Handled = true;// Esto hace que la letra pulsada no llegue a ninguna parte.
            
            //Ejemplo: no se pueden escribir espacios
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

            //Manejar intro
            if (e.KeyChar == (char) Keys.Enter)// O simplemente 13
            {
                label1.Text = textBox1.Text;
                e.Handled = true;
                textBox2.Focus();
            }

            //Manejar ESC
            if (e.KeyChar == 27)
            {
                label1.Text = "";
                e.Handled = true;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Seleccionar todo con Ctrl + Alt + T
            if (e.KeyCode == Keys.T && e.Control && e.Alt)
            {
                textBox1.SelectAll();
                //Evita que genere el evento KeyPress
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                textBox1.Clear();
                e.SuppressKeyPress = true;
            }
        }
    }
}