namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        private string path = "bloc.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nuevo
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Guardar
            StreamWriter sw = new StreamWriter(path);

            foreach (string line in textBox1.Lines)
            {
                sw.WriteLine(line);
            }

            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrir
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                List<string> lines = new List<string>();

                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

                sr.Close();

                textBox1.Lines = lines.ToArray();
            }
            else
            {
                MessageBox.Show("No existe el fichero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}