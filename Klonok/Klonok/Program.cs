using System;
using System.Collections.Generic;

namespace Klonok
{
    public enum SugarvetoSzine
    {
        KEK,
        ZOLD,
        PIROS

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Klonok k1 = new Klonok("Joel",2);
            k1.Nev = "Johnny";

            Ezred ezred = new Ezred();
            ezred.AddKlon("Adam",0);

            Console.WriteLine(k1.);

            Console.ReadLine();
        }
    }
}
