namespace ConversorPulgadas
{
    public partial class Form1 : Form
    {
        private bool wait = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double cm;

            if (!wait && double.TryParse(textBox1.Text.Trim(), out cm))
            {
                wait = true;

                textBox2.Text = Converter.CmToInches(cm).ToString();

                wait = false;
            }

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            double inches;

            if (!wait && double.TryParse(textBox2.Text.Trim(), out inches))
            {
                wait = true;

                textBox1.Text = Converter.InchesToCm(inches).ToString();

                wait = false;
            }
        }
    }
}