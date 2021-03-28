namespace Ingatlan
{
    public abstract class Lakas : Ingatlan
    {
        protected int terulet;
        protected int szobakSzama;
        protected int lakokSzama;
        protected int negyzetmeterAr;

        protected Lakas(int terulet, int szobakSzama, int lakokSzama, int negyzetmeterAr)
        {
            this.terulet = terulet;
            this.szobakSzama = szobakSzama;
            this.lakokSzama = lakokSzama;
            this.negyzetmeterAr = negyzetmeterAr;
        }

        public abstract bool Bekoltozik(int emberekSzama);

        public int OsszesKoltseg()
        {
            return this.terulet * this.negyzetmeterAr;
        }

        public int LakokSzama()
        {
            return this.lakokSzama;
        }

        public override string ToString()
        {
            return "Terulet: " + this.terulet +
                   "\n Szobak szama: " + this.szobakSzama +
                   "\n Lakok szama: " + this.lakokSzama +
                   "\n Negyzetmeter Ar: " + this.negyzetmeterAr + "Ft";
        }

    }
}
