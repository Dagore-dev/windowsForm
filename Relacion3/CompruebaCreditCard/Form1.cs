namespace CompruebaCreditCard
{
    public partial class CompruebaCreditCard : Form
    {
        private TextBox[] textboxes;
        public CompruebaCreditCard()
        {
            InitializeComponent();
            textboxes = new TextBox[]
            {
                textBox1, textBox2, textBox3
            };
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            TextFilters.CheckNumeric(e);

            if (tb.Text.Length == 3)
            {
                textBox2.Focus();
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            TextFilters.CheckNumeric(e);

            if (tb.Text.Length == 3)
            {
                textBox3.Focus();
            }
        }
        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            TextFilters.CheckNumeric(e);

            if (tb.Text.Length == 3)
            {
                textBox4.Focus();
            }
        }
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckNumeric(e);

            TextBox tb = sender as TextBox;
            TextFilters.CheckNumeric(e);


            if (e.KeyChar != 8)
            {
                if (tb.Text.Length == 3)
                {
                    if (IsValidCreditCard(e.KeyChar))
                    {
                        MessageBox.Show("Tarjeta de crédito válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tarjeta de crédito incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (tb.Text.Length > 3)
                {
                    e.Handled = true;
                }
            }
        }
        private bool IsValidCreditCard (char c)
        {
            int[] creditCard = new int[16];

            foreach (TextBox tb in textboxes)
            {
                for (int i = 0; i < tb.Text.Length; i++)
                {
                    creditCard[i] = int.Parse(tb.Text[i].ToString());
                }
            }

            creditCard[15] = int.Parse(c.ToString());
            //ESTA SIN TERMINAR
            return true;
        }
    }
}