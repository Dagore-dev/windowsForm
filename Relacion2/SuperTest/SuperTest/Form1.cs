namespace SuperTest
{
    public partial class SuperTest : Form
    {
        private Cuestionario cuestionario;
        private Resultado resultado;
        private List<RadioButton> radioButtonList;
        private string path = "cuestionario.txt";
        private bool started;
        private int current;

        public SuperTest()
        {
            InitializeComponent();
            radioButtonList = new List<RadioButton>() { radioButton1, radioButton2, radioButton3};
            resultado = new Resultado();
            started = false;
            current = -1;
        }

        private void Visible(bool b)
        {
            labelQuestion.Visible = b;
            btnNext.Visible = b;
            radioButton1.Visible = b;
            radioButton2.Visible = b;
            radioButton3.Visible = b;
        }
        private void SetQuestion ()
        {
            Pregunta pregunta = cuestionario[current];

            labelQuestion.Text = pregunta.Texto;
            radioButton1.Text = pregunta[0].Texto;
            radioButton2.Text = pregunta[1].Texto;
            radioButton3.Text = pregunta[2].Texto;
        }
        private void NextQuestion()
        {
            string output;

            if (current != -1)
            {
                resultado.Guardar(cuestionario, current, radioButtonList);
            }

            current++;
            
            if (current < cuestionario.NumeroPreguntas)
            {
                SetQuestion();
            }
            else
            {
                output = resultado.ToString() + "\n¿Quiere realizar otro intento?";
                DialogResult dr = MessageBox.Show(output, "Cuestionario finalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Visible(false);
                    started = false;
                    current = -1;
                }
                else
                {
                    Close();
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                Visible(true);

                NextQuestion();

                started = true;
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