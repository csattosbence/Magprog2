using System;
using System.Collections.Generic;
namespace Klonok
{
    class Ezred
    {
        private List<Klonok> klonok = new List<Klonok>();


        public void AddKlon(string name, int battles)
        {
            if (cloneAlreadyExists(name))
            {
                throw new Exception("Clone Already Exists");
            }
            else klonok.Add(new Klonok(name, battles));
        }
        public void AddKlon(string name, int battles, SugarvetoSzine sugarveto, bool isPrivate)
        {
            if (cloneAlreadyExists(name))
            {
                throw new Exception("Clone Already Exists");
            }
            else klonok.Add(new Klonok(name, battles, sugarveto, isPrivate));
        }
        public Klonok LegtapasztaltabbKlon()
        {
            Klonok k = new Klonok("Test", 0);
            for (int i = 0; i < klonok.Count; i++)
            {
                if (klonok[i].UtkozetekSzama > k.UtkozetekSzama)
                {
                    k = klonok[i];
                }
            }
            return k;
        }
        public double UtkozetAtlaga()
        {
            int summ = 0;
            foreach (Klonok k in klonok)
            {
                k.UtkozetekSzama += summ;
            }
            return summ / klonok.Count;

        }
        public List<Klonok> KlonokAdottSugarvetovel(SugarvetoSzine sugarveto)
        {
            List<Klonok> temp = new List<Klonok>();
            foreach (Klonok k in klonok)
            {
                if (k.SugarvetoSzine == sugarveto)
                {
                    temp.Add(k);
                }
            }
            return temp;
        }



        private bool cloneAlreadyExists(string name)
        {

            for (int i = 0; i < klonok.Count; i++)
            {
                if (klonok[i].Nev == name)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
