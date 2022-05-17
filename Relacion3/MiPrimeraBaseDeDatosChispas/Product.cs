using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraBaseDeDatosChispas
{
    public class Product
    {
        private int code;
        private string description;
        private double price;
        private int stock;

        public Product (int code, string description, double price, int stock)
        {
            Code = code;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public int Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

        public override string ToString()
        {
            return $"{Code},'{Description}',{String.Format("{0:0.00}", Price).Replace(',', '.')},{Stock}";
        }
    }
}
