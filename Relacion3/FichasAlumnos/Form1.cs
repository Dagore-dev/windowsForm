namespace FichasAlumnos
{
    public partial class Form1 : Form
    {
        private Grupo grupo;
        public Form1()
        {
            InitializeComponent();
            grupo = new Grupo();

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            toolStripModify.Enabled = false;
            toolStripRemove.Enabled = false;
            
            ResizeListView();
        }
        private void CreateUser ()
        {
            AddUser addUser = new AddUser();
            DialogResult newUser =  addUser.ShowDialog();

            if (newUser == DialogResult.OK && addUser.isValidAlumno)
            {
                grupo.InsertaAlumnoLista(addUser.alumno);
                UpdateListView();
            }
        }
        private void RemoveUser ()
        {
            Alumno alumno;

            if (listView1.SelectedItems.Count != -1)
            {
                alumno = (Alumno)listView1.SelectedItems[0].Tag;
                grupo.Elimina(alumno);
                UpdateListView();
            }
        }
        private void ModifyUser ()
        {
            Alumno alumno;

            if (listView1.SelectedItems.Count != -1)
            {
                alumno = (Alumno)listView1.SelectedItems[0].Tag;

                AddUser addUser = new AddUser(alumno);
                DialogResult modifyUser = addUser.ShowDialog();

                if (modifyUser == DialogResult.OK)
                {

                }

                UpdateListView();
            }
        }
        private void UpdateListView ()
        {
            string[] student;
            listView1.Items.Clear();

            for (int i = 0; i < grupo.NumeroAlumnos; i++)
            {
                student = grupo[i].ToString().Split(';', StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(student) { Tag = grupo[i] });
            }

            ResizeListView();
        }
        private void ResizeListView ()
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                toolStripModify.Enabled = true;
                toolStripRemove.Enabled = true;
            }
            else
            {
                toolStripModify.Enabled = false;
                toolStripRemove.Enabled = false;
            }
        }
        private void ToolStripAdd_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
        private void ToolStripRemove_Click(object sender, EventArgs e)
        {
            RemoveUser();
            
            toolStripModify.Enabled = false;
            toolStripRemove.Enabled = false;
        }
        private void ToolStripModify_Click(object sender, EventArgs e)
        {
            ModifyUser();

            toolStripModify.Enabled = false;
            toolStripRemove.Enabled = false;
        }
    }
}