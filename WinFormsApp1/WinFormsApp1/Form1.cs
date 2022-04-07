namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Incrementa valor del label1.
        private void button1_Click (object sender, EventArgs e)
        {
            int i = int.Parse(label1.Text);
            i++;
            label1.Text = i.ToString();
        }
        //Resetea el valor del label1.
        private void button2_Click (object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        //Saluda con el input al hacer Enter.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int) Keys.Enter)
            {
                string name = textBox1.Text.Trim();
                if (name.Length != 0)
                {
                    label3.Text = $"Hola {name}";
                    this.Text = "";
                    textBox1.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Tienes que escribir el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            label3.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }
    }
}