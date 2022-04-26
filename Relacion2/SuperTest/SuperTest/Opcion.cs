using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTest
{
    internal class Opcion
    {
        private string texto;
        private bool esCorrecta;

        public Opcion (string texto, bool esCorrecta)
        {
            this.texto = texto;
            this.esCorrecta = esCorrecta;
        }

        public string Texto
        {
            get { return texto; }
        }
        public bool EsCorrecta
        {
            get { return esCorrecta; }
        }
    }
}
