
    public class Egyagyas : Szoba
    {
        public Egyagyas() : base(1)
        {

        }

        public override void AtKoltozik(Szoba szoba, int atkoltozokSzama)
        {
            if (szoba is Ketagyas || szoba is Lakosztaly)
            {
                int szabad = szoba.FekvoHely - szoba.Lakok;
                if (szabad >= atkoltozokSzama)
                {
                    szoba.Lakok += atkoltozokSzama;
                    Kikoltozik(atkoltozokSzama);
                }
            }
        }

        public override string ToString()
        {
            return "Egyágyas szoba" + base.ToString();
        }
    }
