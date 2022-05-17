using System.Data.SQLite;
namespace ConectarUnaBaseDeDatos
{
    public partial class Form1 : Form
    {
        string path = "example.db";
        SQLiteConnection conn;

        public Form1()
        {
            //Hay que descargar el SQLiteStudio, no hay que instalarlo va con un ejecutable y listo: https://sqlitestudio.pl/
            //Para usarlo con c# hay que descargar el nuget package que se llama System.Data.SQLite.Core
            //La base de datos se carga en donde mismo se guardan los ficheros que queremos usar en nuestro proyecto. Se crea desde SQLite studio con un nombre y extensión .db
            //Se necesita un conection string, nos podemos ayudar con https://www.connectionstrings.com/
            /*
             NULL
             
             */
            InitializeComponent();

            //Cadena Basic de SQLite.NET
            conn = new SQLiteConnection($"Data Source={path};Version=3;");
            conn.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(conn);

            //Aquí vamos a meter nuestra consulta
            cmd.CommandText = "CREATE TABLE tabla (id INTEGER PRIMARY KEY, texto VARCHAR(50));";

            //Ejecuta una consulta que no responde de vuelta con datos
            cmd.ExecuteNonQuery();   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string texto = textBox2.Text;

            SQLiteCommand cmd = new SQLiteCommand(conn);

            cmd.CommandText = $"INSERT INTO tabla(id, texto) VALUES({id}, '{texto}')";
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SQLiteCommand cmd = new SQLiteCommand(conn);

            cmd.CommandText = "SELECT id, texto FROM tabla;";

            SQLiteDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                int id = data.GetInt32(0);//Campo cero
                string texto = data.GetString(1);//Campo 1

                listBox1.Items.Add($"{id} - {texto}");
            }

            data.Close();
        }
    }
}