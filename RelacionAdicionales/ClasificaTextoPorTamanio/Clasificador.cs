using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificaTextoPorTamanio
{
    internal class Clasificador
    {
        private HashSet<string>[] clasifiedWords;

        public Clasificador (string path)
        {
            clasifiedWords = new HashSet<string>[11];
            
            for (int i = 0; i < 11; i++)
            {
                clasifiedWords[i] = new HashSet<string>();
            }

            ReadFile(path);
        }

        public HashSet<string> this[int index]
        {
            get { return clasifiedWords[index]; }
        }

        private void ReadFile (string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            string[] words;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                words = ProcessLine(line);
                Clasify(words);
            }

            sr.Close();
        }
        private string[] ProcessLine (string line)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in line)
            {
                if (c == ' ' || char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            
            return sb
                .ToString()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
        private void Clasify(string[] words)
        {
            int length;
            foreach (string word in words)
            {
                length = word.Length;
                
                if (length < 10)
                {
                    clasifiedWords[length].Add(word);
                }
                else
                {
                    clasifiedWords[10].Add(word);
                }
            }
        }
    }
}
