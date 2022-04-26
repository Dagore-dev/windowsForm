namespace Listview
{
    public partial class ExplicacionListview : Form
    {
        //Listview es la vista habitual del explorador de archivos de windows y que nos sirve para simular facilmente una tabla con la Vista Details y Grid Lines a true. También es interesante la propiedad FullRowSelect.
        public ExplicacionListview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("Otra columna");
            listView1.Columns[4].Width = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] fields = new string[] { "Nueva fila", "Item1", "Item2", "Item3" };

            //listView1.Items.Add("Nueva Fila");
            //listView1.Items[0].SubItems.Add("Item 1");
            //listView1.Items[0].SubItems.Add("Item 2");
            //listView1.Items[0].SubItems.Add("Item 3");

            listView1.Items.Add(new ListViewItem(fields));
        }
    }
}