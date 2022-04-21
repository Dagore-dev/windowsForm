using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDados
{
    internal class DiceRoller
    {
        private Random r;

        public DiceRoller ()
        {
            r = new Random ();
        }

        public int Roll (int faces)
        {
            return r.Next (faces) + 1;
        }
    }
}
