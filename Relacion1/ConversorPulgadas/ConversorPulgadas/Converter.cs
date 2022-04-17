using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorPulgadas
{
    static class Converter
    {
        private static double cmToInches = 0.393701;
        public static double CmToInches (double cm)
        {
            //1 cm is equal to 0.393701 inches.
            return cm * cmToInches;
        }
        public static double InchesToCm (double inches)
        {
            //1 inch is equal to 2.54 cm.
            return inches / cmToInches;
        }
    }
}
