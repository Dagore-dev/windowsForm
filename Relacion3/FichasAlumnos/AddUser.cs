using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasAlumnos
{
    public partial class AddUser : Form
    {
        public Alumno alumno;
        public bool isValidAlumno;

        public AddUser()
        {
            InitializeComponent();
            isValidAlumno = false;
        }
        public AddUser (Alumno alumno) : this()
        {
            textBoxName.Text = alumno.Nombre;
            dateTimePicker1.Value = alumno.FechaNacimiento;
            checkBox1.Checked = alumno.Repetidor;
            textBoxForFinalGrade.Text = alumno.Calificacion.ToString();

            if (alumno.Sexo)
            {
                radioButtonMan.Checked = true;
            }
            else
            {
                radioButtonWoman.Checked = true;
            }
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    alumno = new Alumno(textBoxName.Text, dateTimePicker1.Value, radioButtonMan.Checked, checkBox1.Checked, double.Parse(textBoxForFinalGrade.Text));
                    isValidAlumno = true;
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
