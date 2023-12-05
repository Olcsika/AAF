
string[]  adatok = File.ReadAllLines("adathalmaz.csv");



for (int i = 0; i < adatok.Length; i++)
{
    //Console.WriteLine(adatok[i]);
   
}
List<int> perc = new List<int>();
List<int> elso = new List<int>();
List<int> masodik = new List<int>();
List<int> harmadik = new List<int>();
List<int> negyedik = new List<int>();
List<int> darab = new List<int>();


for (int i = 0; i < adatok.Length; i++)
{
    string elvag = adatok[i].Split(' ')[0];
    Console.WriteLine(elvag);
    for (int j = 0; j < adatok.Length; j++)
    {
        string elvagos = elvag.Split(";")[0];
        //Console.WriteLine(elvagos);
    }
}





Console.WriteLine("1. feladat : Ennyi időpont {0}",adatok.Length);

Console.WriteLine("2. feladat : {0}");

StreamWriter term = new StreamWriter("termeles.csv");


term.Close();

StreamWriter atlagk = new StreamWriter("atlagKozeli.txt");


term.Close();








