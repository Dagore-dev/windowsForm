using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraBaseDeDatosChispas
{
    public partial class NewProduct : Form
    {
        public Product product;
        public bool isValidProduct;

        public NewProduct()
        {
            InitializeComponent();
            isValidProduct = false;
        }
        public NewProduct (Product product) : this()
        {
            numericUpDownCode.Value = product.Code;
            textBoxDesc.Text = product.Description;
            textBoxPrice.Text = product.Price.ToString();
            numericUpDownStock.Value = product.Stock;

            numericUpDownCode.Enabled = false;
            textBoxDesc.Enabled = false;
            textBoxPrice.Enabled = false;
            btnOk.Text = "Actualizar";
        }

        private void NewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    product = new Product(int.Parse(numericUpDownCode.Value.ToString()), textBoxDesc.Text, double.Parse(textBoxPrice.Text.Replace('.', ',')), int.Parse(numericUpDownStock.Value.ToString()));
                    isValidProduct = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
