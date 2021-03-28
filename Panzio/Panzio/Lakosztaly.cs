using System;

public class Lakosztaly : Szoba
{
    public Lakosztaly(int lakokSzama):base(lakokSzama)
    {
        
    }
   
    public override void AtKoltozik(Szoba szoba, int atkoltozokSzama)
    {
        Console.WriteLine("A Lakosztályból nem lehet átköltözni");
    }

    public override string ToString()
    {
        return "Lakosztály" + base.ToString();
    }
}