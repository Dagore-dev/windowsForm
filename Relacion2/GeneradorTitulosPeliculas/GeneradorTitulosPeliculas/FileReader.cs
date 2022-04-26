using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorTitulosPeliculas
{
    internal class FileReader
    {
        public List<string> items;
        
        public FileReader (string path)
        {
            items = new List<string> ();
            StreamReader sr = new StreamReader (path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine ().Trim();
                
                if (line.Length != 0)
                {
                    items.Add(line);
                }
            }

            sr.Close ();
        }

        public string this[int index]
        {
            get { return items[index]; }
        }
    }
}
