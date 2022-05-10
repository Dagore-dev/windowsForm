using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFiltros
{
    static class TextFilters
    {
        static private char[] NIFtable = new char[]
        {
            'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'
        };
        
        public static void CheckNumeric(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != 8 && !char.IsDigit(c))//8 es el código ASCII del retroceso.
            {
                e.Handled = true;
            }
        }
        public static void CheckInteger(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            char c = e.KeyChar;

            if (c == 8 || char.IsDigit(c) || (tb.SelectionStart == 0 && c == '-'))
            {
                if(char.IsDigit(c))
                {
                    if(tb.SelectionStart != tb.Text.Length && tb.Text[tb.SelectionStart] == '-')
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void CheckReal(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            string text = tb.Text;
            char c = e.KeyChar;
            CheckInteger(sender, e);

            if (text.Length > 0 && c == ',' && !text.Contains(',') && char.IsDigit(text[tb.SelectionStart - 1]))
            {
                e.Handled = false;
            }
        }
        public static void CheckLetter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != 8 && !char.IsLetter(c))
            {
                e.Handled = true;
            }
        }
        public static void CheckAlphanumeric(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != 8 && !char.IsLetterOrDigit(c))
            {
                e.Handled = true;
            }
        }
        public static void CheckNIF(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            char c = e.KeyChar;

            tb.ForeColor = Color.Black;

            if (tb.Text.Length < 8)
            {
                CheckNumeric(e);
            }
            else if (tb.Text.Length == 8)
            {
                CheckLetter(e);
                if (!IsValidNIFLetter(tb.Text, c))
                {
                    tb.ForeColor = Color.Red;
                }
            }
            else
            {
                if (c != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private static bool IsValidNIFLetter (string text, char c)
        {
            int nif = int.Parse(text.Substring(0, 8));
            int index = nif % 23;

            return NIFtable[index] == c;
        }
    }
}
