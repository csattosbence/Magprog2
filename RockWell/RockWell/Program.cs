using System;

namespace RockWell
{

    class RockWell
    {
        static void Main(string[] args)
        {
            OvatosDiak diak = new OvatosDiak(4000,"Lehel",200);
            int sorAra = 200;
            int sorokSzama = diak.GetPenz() / sorAra;
            

            for (int i = 0; i < sorokSzama - 1; i++)
            {
                diak.Sorozik(sorAra);
                Console.WriteLine(diak.ToString());
            }


            Console.ReadLine();

        }
    }
}
