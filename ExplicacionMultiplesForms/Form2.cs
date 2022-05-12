using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplicacionMultiplesForms
{
    public partial class Form2 : Form
    {
        public string s = "";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string text) : this()
        {
            label1.Text = text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            s = textBox1.Text;
        }
        //EN LUGAR DE HACER ESTO SE TOCAN LAS PROPIEDADES ACCEPTBUTTON Y CANCELBUTTON DEL FORM Y SE ASIGNAN ESOS BOTONES. Y a los botones su dialog result.
    }
}
