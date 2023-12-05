StreamReader adatok = new StreamReader("adathalmazaok.txt");

adatok.ReadLine();
List<int> perc = new List<int>();
List<int> elso = new List<int>();
List<int> masodik = new List<int>();
List<int> harmadik = new List<int>();
List<int> negyedik = new List<int>();
List<int> darab = new List<int>();

while (!adatok.EndOfStream)
{
    string sor = adatok.ReadLine();
    string[] vag = sor.Split(" ");
    perc.Add(Convert.ToInt32(vag[0]));
   


