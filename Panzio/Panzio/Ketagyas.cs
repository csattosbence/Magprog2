class Ketagyas : Szoba, Kedvezmenyes
{
    public Ketagyas() : base(2)
    {

    }

    public override void AtKoltozik(Szoba szoba, int atkoltozokSzama)
    {
        if (szoba is Lakosztaly)
        {
            int szabad = szoba.FekvoHely - szoba.Lakok;
            if (szabad >= atkoltozokSzama)
            {
                szoba.Lakok += atkoltozokSzama;
                Kikoltozik(atkoltozokSzama);
            }
        }
    }

    public void KedvezmenytKer()
    {
        if(this.Lakok < 2)
        {
            this.BerletiDij = Arak.EGYAGYAS;
        }
    }

    public override string ToString()
    {
        return "Kétágyas szoba" + base.ToString();
    }
}