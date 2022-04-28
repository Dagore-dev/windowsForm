using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGatos
{
    internal class CSVLoader
    {
        private CSV csv;
        public CSVLoader (string path)
        {
            csv = LoadCSV(path);
        }

        public CSV CSV { get { return csv; } }

        private CSV LoadCSV (string path)
        {
            StreamReader sr = new StreamReader (path);
            List<string[]> rows = new List<string[]>();
            string[] columnsName = sr.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            Sanitize(columnsName);
            string[] row;

            while (!sr.EndOfStream)
            {
                row = sr.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                Sanitize(row);

                rows.Add(row);
            }

            sr.Close();
            return new CSV(columnsName, rows);
        }
        private void Sanitize (string[] row)
        {
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = row[i].Trim();
                row[i] = RemoveQuotes(row[i]);
            }
        }
        private string RemoveQuotes (string s)
        {
            string result = s;

            if (s.StartsWith('"') && s.EndsWith('"'))
            {
                result = s.Substring(1, s.Length - 2);
            }

            return result;
        }
    }
}
