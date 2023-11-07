
//Szógenerálás
static string generalas(int betuszam)
{
    string betuk = "öüóúőpoiuztrewqasdfghjkléáűmnbvcxyí";
    string szo = "";
    var rand = new Random();

    for (int i = 0; i < betuszam; i++)
    {
        szo += betuk[rand.Next(betuk.Length)];
    }

    return szo;

}

var rand = new Random();
string[] szavak = new string[10000];

for (int i = 0; i < 10000; i++)
{
    szavak[i] = generalas(rand.Next(4, 6));
}

File.WriteAllLines("szavk.txt", szavak);

//Szókeresés