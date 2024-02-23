using objektum_orientált_progi;
using System;

class auto
{
    public int kerekSzam = 4;
    public void dudal()
    {
        Console.WriteLine("tütütütü!");
    }
    private string tulaj;
    public string tulajdonos
    {
        get
        {
            return tulaj;
        }
        set
        {
            if (value == "Bence")
            {
                Console.WriteLine("EZT NEM");
            }
            else
            {
                tulaj = value;
            }
            
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekSzam);
        kocsi.dudal();
        kocsi.tulajdonos = "gabi";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "csecskó";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "csocska";
        Console.WriteLine(kocsi.tulajdonos);

        Laci laci = new Laci();
        laci.sug();
    }
}