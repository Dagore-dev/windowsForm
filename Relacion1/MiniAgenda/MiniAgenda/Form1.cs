namespace MiniAgenda
{
    public partial class MiniAgenda : Form
    {
        private AgendaController agendaController;
        private string[]? text;
        private bool textChanged = false;

        public MiniAgenda()
        {
            InitializeComponent();
            agendaController = new AgendaController();
        }

        private void LoadState ()
        {
            AgendaEntry entry;
            string path = agendaController.Path;
            bool ok = AgendaEntry.TryFromFile(path, out entry);

            if (ok)
            {
                text = entry.Text;
            }
            else
            {
                text = null;
            }

            UpdateForm();
        }
        private void UpdateForm ()
        {
            textBoxTasks.Lines = text;
            textBoxDay.Text = agendaController.Day.ToString();
            textBoxMonth.Text = agendaController.Month.ToString();
            textBoxYear.Text = agendaController.Year.ToString();
            textChanged = false;
        }
        private void Save ()
        {
            if (textChanged)
            {
                AgendaEntry agendaEntry = new AgendaEntry(agendaController.Date, textBoxTasks.Lines);

                if (HaveContent(textBoxTasks.Lines))
                {
                    agendaEntry.ToFile();
                }
                else
                {
                    if (File.Exists(agendaEntry.Path))
                    {
                        File.Delete(agendaEntry.Path);
                    }
                }
            }
        }
        private bool HaveContent (string[] lines)
        {
            bool hasContent = false;

            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line.Trim()))
                {
                    hasContent = true;
                }
            }

            return hasContent;
        }

        private void MiniAgenda_Load(object sender, EventArgs e)
        {
            LoadState();
        }
        private void MiniAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            Save();
            agendaController.PreviousDay();
            LoadState();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Save();
            agendaController.NextDay();
            LoadState();
        }

        private void TextBoxTasks_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }
    }
}