namespace MiniAgenda
{
    public partial class MiniAgenda : Form
    {
        private AgendaController agendaController;
        private string[]? text;

        public MiniAgenda()
        {
            InitializeComponent();
            agendaController = new AgendaController();
        }

        private void LoadState ()
        {
            string path = agendaController.Path;

            try
            {
                AgendaEntry agendaEntry = AgendaEntry.FromFile(path);
                text = agendaEntry.Text;

            } catch 
            {
                text = null;
            } finally
            {
                UpdateForm();
            }
        }
        private void UpdateForm ()
        {
            textBoxTasks.Lines = text;
            textBoxDay.Text = agendaController.Day.ToString();
            textBoxMonth.Text = agendaController.Month.ToString();
            textBoxYear.Text = agendaController.Year.ToString();
        }
        private void Save ()
        {
            if (HaveContent(textBoxTasks.Lines))
            {
                AgendaEntry agendaEntry = new AgendaEntry(agendaController.Date, textBoxTasks.Lines);
                agendaEntry.ToFile();
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
    }
}