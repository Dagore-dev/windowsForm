namespace FlagGenerator
{
    public partial class FlagGenerator : Form
    {
        private Button[,] buttons;
        private Color[,] flag;

        public FlagGenerator()
        {
            InitializeComponent();
            buttons = new Button[,]
            {
                {
                    btn00, btn01, btn02,
                },
                {
                    btn10, btn11, btn12,
                },
                {
                    btn20, btn21, btn22,
                }
            };
        }

        private void BtnFlag_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            DialogResult colorResult = colorDialog1.ShowDialog();

            if (colorResult == DialogResult.OK)
            {
                btn.BackColor = colorDialog1.Color;
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult openResult = openFileDialog1.ShowDialog();
            string path;

            if (openResult == DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                if (path.EndsWith(".flag"))
                {
                    flag = FlagFiles.Load(path);

                    for (int i = 0; i < flag.GetLength(0); i++)
                    {
                        for (int j = 0; j < flag.GetLength(1); j++)
                        {
                            buttons[i, j].BackColor = flag[i, j];
                        }
                    }
                }
            }
        }
    }
}