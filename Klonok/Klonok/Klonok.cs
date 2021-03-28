using System;
namespace Klonok
{
    class Klonok
    {

        public static int id = 0;
        private string nev = "";
        private int utkozetekSzama;
        private SugarvetoSzine sugarvetoSzine;
        private bool tisztE;
        private int nevCsere;

        public string Nev
        {

            set
            {
                if (value.Length >= 3 && value != null && value.Length > this.nev.Length && nevCsere <2)
                {
                    this.nevCsere++;
                    this.nev = value;
                }
                else throw new Exception("Error in name change");
            }
            get
            {
                return this.nev;
            }
        }
        public int UtkozetekSzama
        {
            get => utkozetekSzama;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.utkozetekSzama = value;
                }
                else throw new Exception("Error in utkozetek Szama");
            }
        }
        public SugarvetoSzine SugarvetoSzine { get => sugarvetoSzine; set => sugarvetoSzine = value; }
        public bool TisztE
        {
            get => tisztE;
            set
            {
                if (tisztE == false)
                {
                    this.tisztE = true;
                }
                else throw new Exception("Error occured in tiszte");
            }
        }
        public Klonok(string name, int numberOfBattles)
        {
            id++;
            Nev = name;
            UtkozetekSzama = numberOfBattles;
            SugarvetoSzine = SugarvetoSzine.KEK;
            TisztE = false;
        }
        public Klonok(string name, int numberOfBattles, SugarvetoSzine sugarvetoSzine, bool isPrivate)
        {
            id++;
            Nev = name;
            UtkozetekSzama = numberOfBattles;
            SugarvetoSzine = sugarvetoSzine;
            if (isPrivate == true)
            {
                TiszteAvat();
            }
            else TisztE = false;
        }
        public void TiszteAvat()
        {
            if (this.TisztE == false)
            {
                this.tisztE = true;
            }
            else throw new Exception("The Clone is Already a Private");
        }
        public string toString()
        {
            return null;
        }

    }
}
