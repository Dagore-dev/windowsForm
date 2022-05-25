using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    static class FileManager
    {
        public static string[] LoadTextFile (string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> lines = new List<string>();

            while (!sr.EndOfStream)
            {
                lines.Add(sr.ReadLine());
            }

            sr.Close();
            return lines.ToArray();
        }
        public static void SaveTextFile (string path, string[] lines)
        {
            StreamWriter sw = new StreamWriter(path);

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            
            sw.Close();
        }
    }
}
