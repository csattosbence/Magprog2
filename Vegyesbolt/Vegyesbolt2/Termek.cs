namespace Vegyesbolt2
{
    abstract class Termek
    {
        protected int ar;
        private string nev;
        

        protected Termek(int ar, string nev)
        {
            this.ar = ar;
            this.nev = nev;
        }

        public abstract int MennyibeKerul();

        public override string ToString()
        {
            return this.nev + " - " +this.ar+ "Ft";
        }

    }
}
