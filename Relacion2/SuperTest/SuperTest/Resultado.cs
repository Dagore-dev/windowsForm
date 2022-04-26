using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTest
{
    internal class Resultado
    {
        private Dictionary<int, bool> resultados;

        public Resultado ()
        {
            resultados = new Dictionary<int, bool> ();
        }

        public void Guardar (Cuestionario cuestionario, int current, List<RadioButton> respuesta)
        {
            Pregunta pregunta = cuestionario[current];
            int selectedIndex = respuesta.FindIndex(r => r.Checked);
            string seleccionada;
            string solucion = pregunta.Correcta.Texto;

            if (selectedIndex != -1)
            {
                seleccionada = respuesta[selectedIndex].Text;
                resultados.Add(current, seleccionada == solucion);
            }
            else
            {
                resultados.Add (current, false);
            }
        }

        private string Representation ()
        {
            StringBuilder sb = new StringBuilder ();
            string record;

            foreach (KeyValuePair<int, bool> pair in resultados)
            {
                record = $"{pair.Key + 1} - {(pair.Value ? "Acertaste" : "Fallaste")}";
                sb.AppendLine (record);
            }
            
            return sb.ToString ();
        }
        public override string ToString()
        {
            return Representation();
        }
    }
}
