public abstract class Szoba
{
    private int berletiDij;
    private int fekvoHely;
    private int lakok;

    public int BerletiDij { get => berletiDij; set => berletiDij = value; }
    public int FekvoHely { get => fekvoHely; set => fekvoHely = value; }
    public int Lakok { get => lakok; set => lakok = value; }

    public Szoba(int lakok)
    {
        this.lakok = lakok;
        this.fekvoHely = lakok;
        this.berletiDij = BerletiDijSzamitas(lakok);
    }

    public override string ToString()
    {
        return
            "Bérleti Díj: " + this.berletiDij + "Ft" +
            "\n Férőhelyek: " + this.fekvoHely +
            "\n Lakók Száma: " + this.lakok;
    }

    private int BerletiDijSzamitas(int lakok)
    {

        if (lakok == 1)
        {
            return Arak.EGYAGYAS;
        }
        else return Arak.KETAGYAS + (lakok - 2) * Arak.EGYAGYAS;
    }

    public virtual void Kikoltozik(int kikoltozokSzama)
    {
        if (this.lakok - kikoltozokSzama >= 0)
            this.lakok -= kikoltozokSzama;
    }
    public abstract void AtKoltozik(Szoba szoba, int atkoltozokSzama);
}
