using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FichasAlumnos
{
    public class Grupo
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();

        public Alumno this[int index]
        {
            get { return listaAlumnos[index]; }
        }
        public int NumeroAlumnos
        {
            get
            {
                return listaAlumnos.Count;
            }
        }

        public bool Elimina (Alumno alumno)
        {
            return listaAlumnos.Remove(alumno);
        }
        public void InsertaAlumnoLista (Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void InsertaAlumnoLista (string nombre, DateTime fechaNacimento, bool sexo, bool repetidor, double calificacion)
        {
            listaAlumnos.Add(new Alumno(nombre, fechaNacimento, sexo, repetidor, calificacion));
        }
        public void EscribeFicheroBinario (string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            Alumno alumno;

            bw.Write(NumeroAlumnos);

            for (int i = 0; i < NumeroAlumnos; i++)
            {
                alumno = listaAlumnos[i];

                bw.Write(alumno.Nombre);
                bw.Write(alumno.FechaNacimiento.ToBinary());
                bw.Write(alumno.Sexo);
                bw.Write(alumno.Repetidor);
                bw.Write(alumno.Calificacion);
            }

            bw.Close();
            fs.Close();
        }
        public void LeeFicheroBinario (string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Alumno alumno;
            int length = br.ReadInt32();
            listaAlumnos.Clear();

            for (int i = 0; i < length; i++)
            {
                alumno = new Alumno(br.ReadString(), DateTime.FromBinary(br.ReadInt64()), br.ReadBoolean(), br.ReadBoolean(), br.ReadDouble());

                listaAlumnos.Add(alumno);
            }

            br.Close();
            fs.Close();
        }
        public void EscribeFicheroTexto (string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Alumno alumno;

            sw.WriteLine(NumeroAlumnos);

            for (int i = 0; i < NumeroAlumnos; i++)
            {
                alumno = listaAlumnos[i];

                sw.WriteLine(alumno.Nombre);
                sw.WriteLine(alumno.FechaNacimiento.ToString("dd/MM/yyyy"));
                sw.WriteLine(alumno.Sexo);
                sw.WriteLine(alumno.Repetidor);
                sw.WriteLine(alumno.Calificacion);
            }

            sw.Close();
        }
        public void LeeFicheroTexto (string path)
        {
            StreamReader sr = new StreamReader(path);
            Alumno alumno;
            int length = int.Parse(sr.ReadLine());

            for (int i = 0; i < length; i++)
            {
                alumno = new Alumno(sr.ReadLine(), DateTime.Parse(sr.ReadLine()), bool.Parse(sr.ReadLine()), bool.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()));

                listaAlumnos.Add(alumno);
            }

            sr.Close();
        }
        public void EscribeFicheroCSV(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Alumno alumno;

            for (int i = 0; i < NumeroAlumnos; i++)
            {
                alumno = listaAlumnos[i];

                sw.WriteLine($"{alumno.Nombre};{alumno.FechaNacimiento.ToString("dd/MM/yyyy")};{alumno.Sexo};{alumno.Repetidor};{alumno.Calificacion}");
            }

            sw.Close();
        }
        public void LeeFicheroCSV (string path)
        {
            StreamReader sr = new StreamReader(path);
            Alumno alumno;
            string[] record;

            while (!sr.EndOfStream)
            {
                record = sr.ReadLine().Split(";");
                alumno = new Alumno(record[0], DateTime.Parse(record[1]), bool.Parse(record[2]), bool.Parse(record[3]), double.Parse(record[4]));
                listaAlumnos.Add(alumno);
            }

            sr.Close();
        }
        public void ForEach (Action<Alumno> action)
        {
            for (int i = 0; i < NumeroAlumnos; i++)
            {
                action(listaAlumnos[i]);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sb.AppendLine(listaAlumnos[i].ToString());
            }

            return sb.ToString();
        }
    }
}
