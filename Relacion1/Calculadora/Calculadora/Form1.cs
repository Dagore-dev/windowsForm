namespace Calculadora
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            double op1, op2, result;

            if (double.TryParse(tbOperator1.Text.Trim(), out op1) && double.TryParse(tbOperator2.Text.Trim(), out op2))
            {
                tbResult.Text = "";

                switch (btn.Text)
                {
                    case "+": result = op1 + op2; break;
                    case "-": result = op1 - op2; break;
                    case "*": result = op1 * op2; break;
                    case "/": result = Divide(op1, op2); break;
                    default: result = 0; break;
                }

                tbResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Error con los operadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double Divide (double n1, double n2)
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            else
            {
                MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}