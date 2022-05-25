using System;
using System.Text;

namespace Ej3
{
    public class Program
    {
        static void Main(string[] args)
        {
            EncriptaFichero("gatito.jpg.crypt");
        }
        public static void EncriptaFichero (string path)
        {
            if (File.Exists(path))
            {
                string newFilename = NewName(path);
                byte[] data = new byte[8];

                FileStream fsPath = new FileStream(path, FileMode.Open);
                BinaryReader br = new BinaryReader(fsPath);
                FileStream fsNew = new FileStream(newFilename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fsNew);
                long divisibleLength = fsPath.Length - (fsPath.Length % 8);

                while (fsPath.Position < divisibleLength)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        data[i] = br.ReadByte();
                    }

                    InvierteArray(data);
                    ModifyBytes(data);

                    for (int i = 0; i < 8; i++)    
                    {
                        bw.Write(data[i]);
                    }
                }

                while (fsPath.Position < fsPath.Length)
                {
                    bw.Write(br.ReadByte());
                }

                br.Close();
                bw.Close();
                fsPath.Close();
                fsNew.Close();
            }
        }

        private static string NewName(string path)
        {
            string newFilename = "";
            string ext = ".crypt";

            if (path.EndsWith(ext))
            {
                newFilename = path.Substring(0, path.Length - 6);
            }
            else
            {
                newFilename = path + ext;
            }

            return newFilename;
        }
        private static void InvierteArray(byte[] a)
        {
            int i = 0, j = a.Length - 1;
            byte temp;

            while (i < j)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;

                i++;
                j--;
            }

        }
        private static void ModifyBytes(byte[] a)
        {
            int temp;

            for (int i = 0; i < 8; i++)
            {
                if (a[i] < 128)
                {
                    temp = a[i] + 128;
                    a[i] = (byte)temp;
                }
                else
                {
                    temp = a[i] - 128;
                    a[i] = (byte)temp;
                }
            }
        }
    }
}
