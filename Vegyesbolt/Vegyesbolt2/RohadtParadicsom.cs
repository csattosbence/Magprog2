using System;

namespace Vegyesbolt2
{
    class RohadtParadicsom : Termek, Akciozhato
    {
        private double tomeg;


        public int AkciosAr()
        {
            return (int)((ar * tomeg) * 0.8);
        }

        public override int MennyibeKerul()
        {
            return (int)tomeg * ar;
        }

        public RohadtParadicsom(double tomeg, int ar) : base(ar, "Rohadt paradicsom")
        {
            this.tomeg = tomeg;
            this.ar = ar;
        }

        public override string ToString()
        {
            return this.tomeg.ToString()+ " Kg" + " - " + base.ToString(); 
        }

    }
}
