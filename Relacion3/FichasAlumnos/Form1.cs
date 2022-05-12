namespace FichasAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            toolStripModify.Enabled = false;
            toolStripRemove.Enabled = false;
            
            //Sample
            string[] student = new string[] { "Luis González", "30/05/2001", "Hombre", "No", "10.0" };
            listView1.Items.Add(new ListViewItem(student));
            ResizeListView();
        }
        private void ResizeListView ()
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void CreateUser ()
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
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
    }
}