using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivino
{
    class Game
    {
        private int number;
        private int tries;
        private int min;
        private int max;

        public int Number 
        { 
            get { return number; } 
            set { number = value; }
        }
        public int Tries
        {
            get { return tries; }
            set { tries = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public Game ()
        {
            number = 50;
            tries = 1;
            min = -1;
            max = 101;
        }

        public void NextGuessing()
        {
            Number = (Min + Max) / 2;
            Tries++;
        }

    }
}
