using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTest
{
    internal class Pregunta
    {
        private string texto;
        private List<Opcion> opciones;

        public Pregunta (string texto, List<Opcion> opciones)
        {
            this.texto = texto;
            this.opciones = opciones;
        }

        public string Texto
        {
            get { return texto; }
        }
        public Opcion this[int index]
        {
            get { return opciones[index]; }
        }
    }
}
