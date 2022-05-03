namespace CreacionElementos
{
    public partial class Form1 : Form
    {
        private int count;
        private int position;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            position = 0;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            
            btn.Text = count.ToString();
            btn.Location = new Point(0, position);
            btn.Click += new EventHandler(DinamicBtn_Click);
            position += 30;
            count++;

            Controls.Add(btn);
        }
        private void DinamicBtn_Click (object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            string msg = $"Botón número {btn.Text}";

            MessageBox.Show(msg, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}