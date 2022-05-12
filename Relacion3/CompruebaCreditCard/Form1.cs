using System.Text;

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
                textBox1, textBox2, textBox3, textBox4
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
            string creditCardNumber = StoreCreditCard(c);

            StringBuilder digitsOnly = new StringBuilder();

            foreach (char n in creditCardNumber.Where(n => char.IsDigit(n)))
            {
                digitsOnly.Append(n);
            }

            if (digitsOnly.Length > 18 || digitsOnly.Length < 15) return false;

            int sum = 0;
            int digit = 0;
            int addend = 0;
            bool timesTwo = false;

            for (int i = digitsOnly.Length - 1; i >= 0; i--)
            {
                digit = Int32.Parse(digitsOnly.ToString(i, 1));
                if (timesTwo)
                {
                    addend = digit * 2;
                    if (addend > 9)
                        addend -= 9;
                }
                else
                    addend = digit;

                sum += addend;

                timesTwo = !timesTwo;

            }
            return (sum % 10) == 0;
        }
        private string StoreCreditCard (char c)
        {
            StringBuilder sb = new StringBuilder();

            foreach (TextBox tb in textboxes)
            {
                sb.Append(tb.Text);
            }

            sb.Append(c);

            return sb.ToString();
        }
    }
}