using System;
using System.Collections.Generic;
using System.Text;

namespace FichasAlumnos
{
    public class Alumno
    {
        private string nombre;
        private DateTime fechaNacimiento;
        bool sexo;
        bool repetidor;
        private double calificacion;

        public Alumno (string nombre, DateTime fechaNacimiento, bool sexo, bool repetidor, double calificacion)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Repetidor = repetidor;
            Calificacion = calificacion;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != "")
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("El nombre no puede estar en blanco.");
                }
            }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public bool Repetidor
        {
            get { return repetidor; }
            set { repetidor = value; }
        }
        public double Calificacion
        {
            get
            {
                return calificacion;
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    throw new Exception("La calificación debe estar entre 1 y 10.");
                }
            }
        }

        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            return alumno1.Nombre == alumno2.Nombre && alumno1.Calificacion == alumno2.Calificacion && alumno1.FechaNacimiento == alumno2.FechaNacimiento && alumno1.Repetidor == alumno2.Repetidor && alumno1.Sexo == alumno2.Sexo;
        }
        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }

        public override string ToString()
        {
            return $"{Nombre};{FechaNacimiento.ToString("dd/MM/yyyy")};{(Sexo ? "Hombre" : "Mujer")};{(Repetidor ? "Sí" : "No")};{Calificacion}";
        }

    }
}
