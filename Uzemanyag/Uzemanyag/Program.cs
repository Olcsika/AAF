using System.Xml;
using Uzemanyag;

List<adatok> valtozasok = new List<adatok>();

StreamReader olvas = new StreamReader("uzemanyag.txt");
while(!olvas.EndOfStream)
{
    valtozasok.Add(new adatok(olvas.ReadLine()));

}
olvas.Close();

Console.WriteLine("3. feladat: Változások száma: {0}",valtozasok.Count);


adatok minimum = valtozasok[0];
for(int i = 0; i < valtozasok.Count; i++)
{
    if (valtozasok[i].kulonbseg()<minimum.kulonbseg())
    {
        minimum = valtozasok[i];
    }
}
Console.WriteLine("4. feladat: A legkisebb különbség: {0}", minimum.kulonbseg);

int db = 0;
for(int i = 0; i< valtozasok.Count;i++)
{
    if (minimum.kulonbseg() == valtozasok[i].kulonbseg())
    {
        db++;
    }
}
Console.WriteLine("5. feladat: A legkisebb különbség előfordulása {0}",db);

bool volt = false;
for(int i = 0;i< valtozasok.Count;i++)
{
    if (DateTime.IsLeapYear(valtozasok[i].datum.Year))
    {
        if (valtozasok[i].datum.Month==2 && valtozasok[i].datum.Day == 24)
        {
            volt = true;
            break;
        }
    }
}
if(volt)
{
    Console.WriteLine("6.feladat: Volt változás szökőnapon!");

}
else
{
    Console.WriteLine("6. feladat: Nem volt változás!");
}
StreamWriter ir = new StreamWriter("euro.txt");
for(int i = 0;i<valtozasok.Count ; i++)
{
    Console.WriteLine(valtozasok[i].fileba());
}


