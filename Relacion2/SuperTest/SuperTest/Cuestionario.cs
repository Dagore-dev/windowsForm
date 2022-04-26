using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTest
{
    internal class Cuestionario
    {
        private string descripcion;
        private List<Pregunta> preguntas;

        public Cuestionario (string path)
        {
            preguntas = new List<Pregunta> ();

            if (File.Exists(path))
            {
                CargaPreguntas(path);
            }
        }
        public int NumeroPreguntas
        {
            get { return preguntas.Count; }
        }
        public Pregunta this[int index]
        {
            get { return preguntas [index]; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
        public void CargaPreguntas (string path)
        {
            StreamReader sr = new StreamReader(path);
            Opcion opcion;
            List<Opcion> opciones;
            Pregunta pregunta;
            string[] record;

            descripcion = sr.ReadLine();
            
            while (!sr.EndOfStream)
            {
                record = sr.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                
                if (record.Length == 7)
                {
                    opciones = new List<Opcion> ();

                    for (int i = 1; i < 7; i +=2)
                    {
                        opcion = new Opcion(record[i], bool.Parse(record[i + 1]));
                        opciones.Add(opcion);
                    }
                    
                    pregunta = new Pregunta(record[0], opciones);
                    preguntas.Add(pregunta);
                }
            }

            sr.Close();
        }
    }
}
