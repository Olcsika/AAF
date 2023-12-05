//elso feladat
List<int> szam = new List<int>();
Random r = new Random();
for (int i = 0; i < 500; i++)
{
    szam.Add(r.Next(10000, 100000));   
}
StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0;i < szam.Count;i++)
{
    ir.WriteLine(szam[i]);
}
ir.Close();
//masodik feladat
void par()
{
    int a = 0;
    for (int i = 0; i < szam.Count; i++)
    {
        if (szam[i] % 2 == 0)
        {
            a++;
        }
    }
    Console.WriteLine("2. feladat: A páros számok: "+a );
}
par();
//harmadik feladat
void parat()
{
    int paratlan = 0;
    for (int i = 0; i < szam.Count; i++)
    {
        if (szam[i] % 2 == 1)
        {
            paratlan++;
        }

    }
    Console.WriteLine("3. feladat: A páratlen számok összege: "+paratlan);

}
parat();
//negyedik feladat
int elso = 0;
int masodik = 0;
for (int i = 0;i < szam.Count ; i++)
{
    if (szam.Count<251)
    {
        elso++;
    }
    //Console.WriteLine(elso);

}
//otodik feladat
int harom = 0;
for (int i = 0;i < szam.Count ; i++)
{
    string har = Convert.ToString(szam[i]);
    if (har[0]%10000==3)
    {
        harom++;
    }
    
}
Console.WriteLine(harom);
//hatodik feladat

int egy = 0;
int ketto = 0;
int haromodik = 0;
int negy = 0;
int ot = 0;
int hat = 0;
int het = 0;
int nyolc = 0;
int kilenc = 0;

for(int i = 0;i < szam.Count ; i++)
{
    
    if (szam[i] / 1000==1)
    {
        egy++;
    }
    if (szam[i] / 1000 == 2)
    {
        ketto++;
    }
    if (szam[i] / 1000 == 3)
    {
        haromodik++;
    }
    if (szam[i] / 1000 == 4)
    {
        negy++;
    }
    if (szam[i] / 1000 == 5)
    {
        ot++;
    }
    if (szam[i] / 1000 == 6)
    {
        hat++;
    }
    if (szam[i] / 1000 == 7)
    {
        het++;
    }
    if (szam[i] / 1000 == 8)
    {
        nyolc++;
    }
    if (szam[i] / 1000 == 9)
    {
        kilenc++;
    }
}
Console.WriteLine(elso);
Console.WriteLine(masodik);
Console.WriteLine(haromodik);
Console.WriteLine(negy);
Console.WriteLine(ot);
Console.WriteLine(hat);
Console.WriteLine(het);
Console.WriteLine(nyolc);
Console.WriteLine(kilenc);

