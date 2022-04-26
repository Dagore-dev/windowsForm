namespace MultiConvesor
{
    public enum Direction
    {
        FromLeftToRight,
        FromRightToLeft
    }
    public partial class MultiConversor : Form
    {
        private List<RadioButton> radioButtonsLeft;
        private List<RadioButton> radioButtonsRight;
        private bool stop;

        public MultiConversor()
        {
            InitializeComponent();
            radioButtonsLeft = new List<RadioButton> { radioButtonCelsius1, radioButtonFarenheit1, radioButtonKelvin1 };
            radioButtonsRight = new List<RadioButton> { radioButtonCelsius2, radioButtonFarenheit2, radioButtonKelvin2 };
            stop = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int startLength = textBox.Text.Length;

            if (!stop)
            {
                stop = true;

                if (startLength == textBox.Text.Length)
                {
                    double temp = Conversion(textBox, Direction.FromLeftToRight);
                    textBox2.Text = temp.ToString();
                }

                stop = false;
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int startLength = textBox.Text.Length;

            if (!stop)
            {
                stop = true;

                if (startLength == textBox.Text.Length)
                {
                    double temp = Conversion(textBox, Direction.FromRightToLeft);
                    textBox1.Text = temp.ToString();
                }

                stop = false;
            }
        }
        private double Conversion(TextBox textBox, Direction direction)
        {
            double input;
            RadioButton radioButtonLeft = radioButtonsLeft.Find(r => r.Checked);
            RadioButton radioButtonRight = radioButtonsRight.Find(r => r.Checked);
            Temperatura t = new Temperatura(0, UnidadTemperatura.Kelvin);
            UnidadTemperatura uLeft, uRight;

            if (double.TryParse(textBox.Text, out input))
            {
                uLeft = (UnidadTemperatura) int.Parse(radioButtonLeft.Tag.ToString());
                uRight = (UnidadTemperatura) int.Parse(radioButtonRight.Tag.ToString());

                if (direction == Direction.FromLeftToRight)
                {
                    t = new Temperatura(input, uLeft);
                    t = t.ConvierteEn(uRight);
                }
                else
                {
                    t = new Temperatura(input, uRight);
                    t = t.ConvierteEn(uLeft);
                }
            }
            else
            {
                if (textBox.Text.Length != 0)
                {
                    MessageBox.Show("No has introducido una temperatura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return t.Valor;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            double temp;

            if (!stop)
            {
                stop = true;

                if (textBox1.Text.Length != 0)
                {
                    temp = Conversion(textBox1, Direction.FromLeftToRight);
                    textBox2.Text = temp.ToString();
                }

                if (textBox2.Text.Length != 0)
                {
                    temp = Conversion(textBox2, Direction.FromRightToLeft);
                    textBox1.Text = temp.ToString();
                }

                stop = false;
            }
        }
    }
}