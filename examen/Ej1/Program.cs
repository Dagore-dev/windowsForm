using System;
using System.Text;

namespace Inventario 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Inventario inv = new Inventario();
            inv.AbreCsv("inventario.csv");
            Console.WriteLine(inv);
            inv.GuardaCsv("inventario2.csv");
        }
    }
}