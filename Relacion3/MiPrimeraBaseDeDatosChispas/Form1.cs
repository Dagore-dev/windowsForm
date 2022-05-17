using System.Data.SQLite;

namespace MiPrimeraBaseDeDatosChispas
{
    public partial class DBChispas : Form
    {
        private SQLiteConnection conn;
        private string path = "chispas.db";

        public DBChispas()
        {
            InitializeComponent();

            conn = new SQLiteConnection($"Data Source={path};Version=3;");
            conn.Open();

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            toolStripModify.Enabled = false;
            toolStripRemove.Enabled = false;

            UpdateListView();
            ResizeListView();
        }

        private void ResizeListView()
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private SQLiteDataReader SelectProducts ()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "SELECT codigo, descripcion, precio, stock FROM productos;";
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        private void InsertProduct(Product product)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = $"INSERT INTO productos(codigo, descripcion, precio, stock) VALUES ({product});";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateListView();
        }
        private void RemoveProduct(Product product)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = $"DELETE FROM productos WHERE codigo = {product.Code};";
                cmd.ExecuteNonQuery();

                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProduct(Product product)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = $"UPDATE productos SET stock = {product.Stock} WHERE codigo = {product.Code};";
                cmd.ExecuteNonQuery();

                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateListView()
        {
            SQLiteDataReader data = SelectProducts();

            if (data != null)
            {
                Product product;
                string desc;
                string[] productFields;
                listView1.Items.Clear();

                while (data.Read())
                {
                    product = new Product(data.GetInt32(0), data.GetString(1), data.GetDouble(2), data.GetInt32(3));
                    productFields = product.ToString().Split(',', StringSplitOptions.RemoveEmptyEntries);
                    
                    desc = productFields[1];
                    desc = desc.Substring(1, desc.Length - 2);
                    productFields[1] = desc;

                    listView1.Items.Add(new ListViewItem(productFields) { Tag = product });
                }

                data.Close();
                toolStripModify.Enabled = false;
                toolStripRemove.Enabled = false;
                ResizeListView();
            }
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
        private void DBChispas_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            DialogResult productResult = newProduct.ShowDialog();

            if (productResult == DialogResult.OK && newProduct.isValidProduct)
            {
                InsertProduct(newProduct.product);
            }
        }
        private void ToolStripRemove_Click(object sender, EventArgs e)
        {
            Product product;
            if (listView1.SelectedItems.Count != -1)
            {
                product = (Product) listView1.SelectedItems[0].Tag;
                RemoveProduct(product);
            }
        }
        private void ToolStripModify_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != -1)
            {
                Product product = (Product) listView1.SelectedItems[0].Tag;
                NewProduct newProduct = new NewProduct(product);
                DialogResult productResult = newProduct.ShowDialog();

                if (productResult == DialogResult.OK && newProduct.isValidProduct)
                {
                    UpdateProduct(newProduct.product);
                }
            }
        }
    }
}