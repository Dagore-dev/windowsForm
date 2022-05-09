using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagGenerator
{
    static class FlagFiles
    {
        public static Color[,] Load(string path)
        {
            Color[,] flag = new Color[3, 3];
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Color color = Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte());
                    flag[i, j] = color;
                }
            }

            br.Close();
            fs.Close();

            return flag;
        }
        public static void Save(string path, Color[,] flag)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            Color color;

            for (int i = 0; i < flag.GetLength(0); i++)
            {
                for (int j = 0; j < flag.GetLength(1); j++)
                {
                    color = flag[i, j];
                    bw.Write(color.R);
                    bw.Write(color.G);
                    bw.Write(color.B);
                }
            }

            bw.Close();
            fs.Close();
        }
    }
}
