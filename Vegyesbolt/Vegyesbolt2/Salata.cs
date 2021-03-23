namespace Vegyesbolt2
{
    class Salata : Termek
    {
        private int darab;
        private int ar;

        public override int MennyibeKerul()
        {
            return this.darab * this.ar;
        }
        public Salata(int darab,int ar) : base(ar,"Salata")
        {
            this.ar = ar;
            this.darab = darab;
        }
        public override string ToString()
        {
            return this.darab + " Darab" + " - " + base.ToString();
        }
    }
}
