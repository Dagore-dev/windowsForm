using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniAgenda
{
    class AgendaEntry
    {
        private DateTime lastModification;
        private string[] text;

        public AgendaEntry (DateTime date, string[] text)
        {
            this.lastModification = date;
            this.text = text;
        }

        public DateTime Date { get { return lastModification; } set { lastModification = value; } }
        public string[] Text 
        {
            get { return text; } 
            set { text = value; }
        }

        public void ToFile ()
        {
            StreamWriter sw = new StreamWriter ($"{Date.ToString("ddMMyyyy")}.txt");

            foreach (string line in text)
            {
                sw.WriteLine(line);
            }

            sw.Close();
        }
        public static AgendaEntry FromFile (string path)
        {
            if (CheckPathFormat(path))
            {
                if (File.Exists(path))
                {
                    List<string> lines = new List<string>();
                    StreamReader sr = new StreamReader(path);
                    string date;

                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());
                    }

                    sr.Close();

                    date = $"{path.Substring(0,2)}-{path.Substring(2, 2)}-{path.Substring(4, 4)}";
                    return new AgendaEntry(DateTime.Parse(date), lines.ToArray());
                }
                else
                {
                    throw new Exception($"{path} not found.");
                }
            }
            else
            {
                throw new Exception($"{path} hasn't a correct format. Try something like: \"02021994.txt\".");
            }
        }
        private static bool CheckPathFormat (string path)
        {
            Regex regex = new Regex("^\\d{8}\\.txt$");

            return regex.IsMatch(path);
        }
    }
}
