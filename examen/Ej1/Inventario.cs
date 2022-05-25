using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventario
{
    public class Inventario
    {
        List<Producto> listaProductos;

        public Inventario()
        {
            listaProductos = new List<Producto>();
        }

        public bool AbreCsv(string fichero)
        {
            bool todoBien = true;
            StreamReader sr = new StreamReader(fichero);
            
            string cabeceras = sr.ReadLine();
            
            if(cabeceras == "SKU;Nombre;Descripcion;FechaEntrada;Precio;Cantidad")
            {
                while(!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    Producto p = Producto.Parse(linea);
                    listaProductos.Add(p);
                }
            }
            else
            {
                todoBien = false;
            }

            sr.Close();

            return todoBien;
        }
        
        public void GuardaCsv(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            sw.WriteLine("SKU;Nombre;Descripcion;FechaEntrada;Precio;Cantidad");

            for (int i = 0; i < listaProductos.Count; i++)
            {
                sw.WriteLine(listaProductos[i].ToCsv());
            }

            sw.Close();
        }

        public override string ToString()
        {
            string[] cabeceras = { "SKU", "Nombre", "Fecha Entrada", "Precio", "Cantidad" };
            int[] tamanos = { 13, 43, 14, 10, 10 };

            string texto = cabeceras[0].PadRight(tamanos[0]) + cabeceras[1].PadRight(tamanos[1]) + cabeceras[2].PadRight(tamanos[2]) + cabeceras[3].PadLeft(tamanos[3]) +
                cabeceras[4].PadLeft(tamanos[4]) + "\n";

            texto = texto + "".PadLeft(Enumerable.Sum(tamanos), '-') + "\n";

            for (int i = 0; i < listaProductos.Count; i++)
            {
                texto = texto + listaProductos[i].ToString() + "\n";
            }

            return texto;
        }
    }
}
