using System.Text;

namespace ReservaBus
{
    public partial class ReservaBus : Form
    {
        private List<Button> buttonList;
        
        public ReservaBus()
        {
            InitializeComponent();

            buttonList = new List<Button>();
            listView1.Columns.Add("Reserva");
            listView1.Columns.Add("Plazas");
            UpdateColumsSize();

            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button btn;
            Point point = new Point(0, 0);
            int size = 28;
            string place;

            for (int i = 0; i < 64; i++)
            {
                btn = new Button();

                btn.Width = size;
                btn.Height = size;
                btn.BackColor = Color.Green;
                place = (i + 1).ToString().PadLeft(2, '0');

                if (i != 0)
                {
                    if (point.X == size)
                    {
                        point.X += (size * 2);
                    }
                    else
                    {
                        if (point.X == (size * 4))
                        {
                            point.X = 0;
                            point.Y += size;
                        }
                        else
                        {
                            point.X += size;
                        }
                    }
                }

                btn.Text = place;
                btn.Location = point;
                btn.Click += new EventHandler(Btn_Seat);
                buttonList.Add(btn);
                splitContainer1.Panel1.Controls.Add(btn);
            }
        }
        private void Btn_Seat(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Yellow;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string name = textBox.Text;
            string[] row;

            if (e.KeyValue == (int)Keys.Enter && name.Length != 0)
            {
                row = MakeRow(name);
                
                if (row[1].Length != 0)
                {
                    listView1.Items.Add(new ListViewItem(row));
                    textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ninguna plaza.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private string[] MakeRow (string name)
        {
            string[] row = new string[2];
            List<Button> buttons = buttonList.FindAll(btn => btn.BackColor == Color.Yellow);
            StringBuilder sb = new StringBuilder();

            row[0] = name;

            for (int i = 0; i < buttons.Count -1; i++)
            {
                sb.Append(buttons[i].Text);
                sb.Append(", ");
                buttons[i].BackColor = Color.Red;
            }

            buttons[buttons.Count - 1].BackColor = Color.Red;
            sb.Append(buttons[buttons.Count - 1].Text);

            row[1] = sb.ToString();

            return row;
        }
        private void UpdateColumsSize()
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}