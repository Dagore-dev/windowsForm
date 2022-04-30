using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
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
    }
}
