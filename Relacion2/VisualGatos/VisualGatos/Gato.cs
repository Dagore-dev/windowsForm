using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGatos
{
    internal class Gato
    {
        private string name;
        private string hairColor;
        private string race;
        private double weight;
        private double size;
        private string eyeColor;

        public Gato(string name, string hairColor, string race, double weight, double size, string eyeColor)
        {
            this.name = name;
            this.hairColor = hairColor;
            this.race = race;
            this.weight = weight;
            this.size = size;
            this.eyeColor = eyeColor;
        }

        public string[] Properties
        {
            get 
            {
                return new string[]
                {
                    name,
                    hairColor,
                    race,
                    String.Format("{0:0.00}", weight).Replace(',', '.'),
                    String.Format("{0:0.00}", size).Replace(',', '.'),
                    eyeColor
                };
            }
        }

        public string Name { get => name; set => name = value; }
        public string HairColor { get => hairColor; set => hairColor = value; }
        public string Race { get => race; set => race = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Size { get => size; set => size = value; }
        public string EyeColor { get => eyeColor; set => eyeColor = value; }
    }
}
