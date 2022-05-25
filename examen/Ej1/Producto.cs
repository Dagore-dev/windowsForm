using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class Producto
    {
        //Atributos
        string sku;
        string nombre;
        string descripcion;
        DateTime fechaEntrada;
        decimal precio;
        int cantidad;

        //Constructor
        public Producto (string sku, string nombre, string descripcion, DateTime fechaEntrada, decimal precio, int cantidad)
        {
            this.sku = CompruebaNoVacio(sku);
            this.nombre = CompruebaNoVacio(nombre);
            Descripcion = descripcion;
            this.fechaEntrada = CompruebaFecha(fechaEntrada);
            Precio = precio;
            Cantidad = cantidad;
        }

        //Comprobaciones
        private string CompruebaNoVacio(string s)
        {
            if (s.Length > 0)
            {
                return s;
            }
            else
            {
                throw new Exception("Una cadena vacía no es un valor válido.");
            }
        }
        private DateTime CompruebaFecha (DateTime dateTime)
        {
            if (dateTime <= DateTime.Now)
            {
                return dateTime;
            }
            else
            {
                throw new Exception("No se puede introducir una fecha posterior");
            }
        }

        //Propiedades
        public string Sku { get => sku; }
        public string Nombre { get => nombre; }
        public DateTime FechaEntrada { get => fechaEntrada; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio 
        { 
            get => precio;
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    throw new Exception("El producto no puede tener un precio negativo.");
                }
            } 
        }
        public int Cantidad 
        { 
            get => cantidad;
            set
            {
                if (value >= 0)
                {
                    cantidad = value;
                }
                else
                {
                    throw new Exception("No se puede guardar una cantidad negativa de producto.");
                }
            }
        }

        //Método estático
        public static Producto Parse (string linea)
        {
            string[] registro = linea.Split (';', StringSplitOptions.RemoveEmptyEntries);

            return new Producto(registro[0], registro[1], registro[2], DateTime.Parse(registro[3]), decimal.Parse(registro[4]), int.Parse(registro[5]));
        }

        //Métodos
        public string ToCsv ()
        {
            return $"{sku};{nombre};{descripcion};{fechaEntrada.ToString("dd/MM/yyyy")};{precio.ToString("f2")};{cantidad.ToString()}";
        }
        public override string ToString()
        {
            string skuField = $"{sku.PadRight(13, ' ')}";
            string nombreField = $"{nombre.PadRight(43, ' ')}";
            string fechaEntradaField = $"{fechaEntrada.ToString("dd/MM/yyyy").PadRight(16, ' ')}";
            string precioField = $"{precio.ToString("f2")} €".PadLeft(8, ' ');
            string cantidadField = $"{cantidad}".PadLeft(10, ' ');

            return $"{skuField}{nombreField}{fechaEntradaField}{precioField}{cantidadField}";
        }

    }
}
