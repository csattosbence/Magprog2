using System;
using System.Collections.Generic;
using System.IO;

namespace Vegyesbolt2
{
    class Vegyesbolt
    {
        private List<Termek> termekek = new List<Termek>();
        static private StreamReader sr;
        static private StreamWriter sw;

        public void Bevasarolok(String utvonal)
        {
            sr = new StreamReader(utvonal);
            
            string[] temp;

            while (!sr.EndOfStream)
            {

                temp = sr.ReadLine().Split(';');
                try
                {
                    if (temp[0] == "salata")
                    {
                        termekek.Add(new Salata(int.Parse(temp[2]), int.Parse(temp[1])));
                    }
                    if (temp[0] == "paradicsom")
                    {
                        termekek.Add(new RohadtParadicsom(Double.Parse(temp[2]), int.Parse(temp[1])));
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            // Salata;4.5;500
            // Rodhadt Paradicsom;3;200
         }

        public void MivanAKosaramban(string utvonal)
        {
            try
            {
                sw = new StreamWriter(utvonal);
                foreach (Termek termek in termekek)
                {
                    sw.WriteLine(termek.ToString());
                }
                sw.WriteLine("A Kosár összege: " + KosarOsszege() + "Ft");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public int KosarOsszege()
        {
            int summ = 0;
            foreach (Termek termek in termekek)
            {
                summ += termek.MennyibeKerul();
            }
            return summ;
        }

        public void Kiiratas()
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                Console.WriteLine(termekek[i].ToString());
            }

        }

        static void Main(string[] args)
        {
            Vegyesbolt bolt = new Vegyesbolt();
            bolt.Bevasarolok("termekek.csv");
            bolt.Kiiratas();
            bolt.MivanAKosaramban("output.txt");

            Console.ReadLine();

        }
    }
}