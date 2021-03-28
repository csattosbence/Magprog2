namespace RockWell
{
    class Diak
    {
        protected string Nev;
        protected int Penz;

        public int GetPenz() {
            return Penz;
        }

        public Diak(string nev, int penz) {
            this.Penz = penz;
            this.Nev = nev;
        }

        virtual public void Sorozik(int sorAra) {
            this.Penz -= sorAra;
        }

    }

    class OvatosDiak : Diak {

        protected int UtazasiKoltseg;


        public override void Sorozik(int sorAra)
        {
            if (Penz - sorAra >= UtazasiKoltseg)
            {
                Penz -= sorAra;
            }
        }

        public override string ToString() {
            return Nev + "Maradek Penze:" + Penz + "Ft" + "Hazautazas dija:" + UtazasiKoltseg + "Ft";
        }

        public OvatosDiak(int penz, string nev,int utazasiKoltseg):base(nev,penz) {
            this.Nev = nev;
            this.Penz = penz;
            this.UtazasiKoltseg = utazasiKoltseg;
        }
    } 


}
