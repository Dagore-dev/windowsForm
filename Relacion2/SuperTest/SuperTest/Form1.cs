namespace SuperTest
{
    public partial class SuperTest : Form
    {
        private Cuestionario cuestionario;
        private string path = "cuestionario.txt";
        private bool started;
        private int current;

        public SuperTest()
        {
            InitializeComponent();
            started = false;
            current = -1;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                btnNext.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

                NextQuestion();

                started = true;
            }
        }
        private void NextQuestion ()
        {
            current++;

            if (current < cuestionario.NumeroPreguntas)
            {
                Pregunta pregunta = cuestionario[current];

                labelQuestion.Text = pregunta.Texto;
                radioButton1.Text = pregunta[0].Texto;
                radioButton2.Text = pregunta[1].Texto;
                radioButton3.Text = pregunta[2].Texto;
            }
        }
        private void SuperTest_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                cuestionario = new Cuestionario(path);
                labelDescription.Text = cuestionario.Descripcion;
            }
            else
            {
                MessageBox.Show($"No se ha encontrado {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}