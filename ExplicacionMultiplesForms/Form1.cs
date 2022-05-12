namespace ExplicacionMultiplesForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textBox1.Text);

            //IMPORTANTE => El método ShowDialog hace un freeze a este programa, hasta que se resuelva no avanza este hilo.
            DialogResult dr = f2.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show($"OK: {f2.s}");
            }
            else
            {
                MessageBox.Show($"Canceled: {f2.s}");
            }
        }
    }
}