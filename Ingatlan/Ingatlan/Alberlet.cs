using System;

namespace Ingatlan
{
    public class Alberlet : Lakas, Berelheto
    {
        private int honapokSzama;

        public Alberlet(int terulet, int szobakSzama, int negyzetmeterAr) : base(terulet, szobakSzama, 0, negyzetmeterAr)
        {
            this.honapokSzama = 0;
        }

        public override bool Bekoltozik(int emberekSzama)
        {
            if (this.lakokSzama >= emberekSzama && terulet / (lakokSzama + emberekSzama) >= 2)
            {
                this.lakokSzama += emberekSzama;
                return true;
            }
            else return false;
        }

        public bool Lefoglal(int honapokSzama)
        {
            if (this.honapokSzama == 0 && honapokSzama > 0)
            {
                this.honapokSzama = honapokSzama;
                return true;
            }
            else return false;
        }

        public bool LefoglaltE()
        {
            if (this.honapokSzama == 0)
            {
                return false;
            }
            else return true;
        }

        public int mennyibeKerul(int honapokSzama)
        {
            if (lakokSzama > 0)
            {
                return (int)(this.OsszesKoltseg() / this.lakokSzama);
            }
            else return -1;
        }

        public override string ToString()
        {
            return "Alberlet" + base.ToString() + "\n Lefoglalt honapok szama: " + this.honapokSzama;
        }
    }
}
