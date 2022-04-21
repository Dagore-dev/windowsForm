using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaDiccionario
{
    public class Pair
    {
        private string key;
        private string value;

        public Pair (string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string Key { get => key; set => key = value; }
        public string Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return $"{Key}, {Value}";
        }
    }
    internal class TranslatedWords
    {
        private string path = "translations.txt";
        private List<string> spanishWords;
        private List<string> englishWords;

        public TranslatedWords()
        {
            spanishWords = new List<string>();
            englishWords = new List<string>();
            
            if (File.Exists(path))
            {
                LoadFromFile(path);
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
        public void CreateFile (string[] list)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < list.Length; i++)
            {;
                sw.WriteLine(list[i]);
            }

            sw.Close();
        }
        public List<Pair> GetWords ()
        {
            List<Pair> list = new List<Pair>();
            Pair pair;

            for (int i = 0; i < spanishWords.Count; i++)
            {
                pair = new Pair (spanishWords[i], englishWords[i]);
                list.Add (pair);
            }

            return list;
        }
    }
}
