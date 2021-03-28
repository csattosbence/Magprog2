using System;
using System.Collections.Generic;
using System.IO;

namespace Panzio
{

    class Panzio
    {
        private static StreamReader sr;
        private static List<Szoba> szobaLista = new List<Szoba>();

        public static void Berel()
        {

            int elsoLakosztalyIndexe = -1;
            int elsoEgyagyasIndexe = -1;
            Lakosztaly elsoLakosztaly;
            try
            {
                for (int i = 0; i < szobaLista.Count; i++)
                {
                    if (szobaLista[i] is Ketagyas)
                    {
                        ((Ketagyas)szobaLista[i]).KedvezmenytKer();
                    }
                    if (elsoEgyagyasIndexe == -1 && szobaLista[i] is Egyagyas)
                    {
                        elsoEgyagyasIndexe = i;
                    }
                    if (elsoLakosztalyIndexe == -1 && szobaLista[i] is Lakosztaly)
                    {
                        elsoLakosztalyIndexe = i;
                    }
                    Console.WriteLine(szobaLista[i].ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            if (elsoEgyagyasIndexe != -1 && elsoLakosztalyIndexe != -1)
            {
                elsoLakosztaly = (Lakosztaly)szobaLista[elsoLakosztalyIndexe];
                elsoLakosztaly.Kikoltozik(1);
                szobaLista[elsoEgyagyasIndexe].AtKoltozik(elsoLakosztaly, 1);
            }

        }

        public static void SzobatKiad(string utvonal)
        {
            try { 
                sr = new StreamReader(utvonal);
                string[] temp;
            
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine().Split(';');
                    if (temp[0] == "egyagyas")
                    {
                        szobaLista.Add(new Egyagyas());
                    }
                    if (temp[0] == "ketagyas")
                    {
                        szobaLista.Add(new Ketagyas());
                    }
                    if (temp[0] == "lakosztaly")
                    {
                        szobaLista.Add(new Lakosztaly(int.Parse(temp[1])));
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void Main(string[] args)
        {
            SzobatKiad("panzio.csv");
            Berel();
            for (int i = 0; i < szobaLista.Count; i++)
            {
                Console.WriteLine(szobaLista[i].ToString());
            }

        }
    }
}
