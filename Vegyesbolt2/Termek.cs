namespace Vegyesbolt2
{
    abstract class Termek
    {
        protected int ar;
        private string nev;

        Termek(string nev, int ar)
        {
            this.ar = ar;
            this.nev = nev;
        }

        public abstract int tenylegesAr();

        public override string ToString()
        {
            return this.nev + " - " + "Ft";
        }

    }
}
