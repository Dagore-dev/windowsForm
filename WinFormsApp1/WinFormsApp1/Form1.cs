namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Evento del click del botón
        private void button1_Click (object sender, EventArgs e)
        {
            int i = int.Parse(label1.Text);
            i++;
            label1.Text = i.ToString();
        }
        private void button2_Click (object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}