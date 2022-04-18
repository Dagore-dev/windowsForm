using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorInglesEspanol
{
    class TranslatedWords
    {
        private string path = "translations.txt";
        private List<string> spanishWords;
        private List<string> englishWords;

        public TranslatedWords ()
        {
            if (File.Exists(path))
            {
                spanishWords = new List<string>();
                englishWords = new List<string>();

                LoadFromFile(path);
            }
            else
            {
                throw new Exception($"{path} not found.");
            }
        }
        private void LoadFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] record;

            while (!sr.EndOfStream)
            {
                record = sr.ReadLine().Split(',');

                spanishWords.Add(record[0].Trim());
                englishWords.Add(record[1].Trim());
            }

            sr.Close();
        }
        public int SpanishIndexOf (string s)
        {
            string clean = s.Trim().ToLower();
            int index = -1;

            for (int i = 0; i < spanishWords.Count; i++)
            {
                if (clean == spanishWords[i])
                {
                    index = i;
                    i = spanishWords.Count;
                }
            }

            return index;
        }
        public int EnglishIndexOf(string s)
        {
            string clean = s.Trim().ToLower();
            int index = -1;

            for (int i = 0; i < englishWords.Count; i++)
            {
                if (clean == englishWords[i])
                {
                    index = i;
                    i = englishWords.Count;
                }
            }

            return index;
        }
        public string GetSpanishWordAt (int n)
        {
            return spanishWords[n];
        }
        public string GetEnglishWordAt (int n)
        {
            return englishWords[n];
        }

    }
}
