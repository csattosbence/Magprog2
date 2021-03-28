using System;

namespace Ingatlan
{
    class CsaladiApartman : Lakas
    {
        private int gyerekekSzama;

        public CsaladiApartman(int terulet, int szobakSzama,int negyzetmeterAr) : base(terulet, szobakSzama, 0, negyzetmeterAr)
        {
            this.gyerekekSzama = 0;
        }

        public bool GyerekSzuletik() {
            if (lakokSzama - gyerekekSzama >= 2)
            {
                this.lakokSzama++;
                this.gyerekekSzama++;
                return true;
            }
            else return false;
        }

        public override bool Bekoltozik(int emberekSzama)
        {
            if (szobakSzama / emberekSzama <= 2 && terulet / emberekSzama >= 10)
            {
                lakokSzama = emberekSzama;

                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return base.ToString() + "Gyerekek Szama: " + this.gyerekekSzama;
        }
    }
}
