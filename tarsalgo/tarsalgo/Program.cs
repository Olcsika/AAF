using tarsalgo;

List<adatok> haladas = new List<adatok>();

StreamReader olvas = new StreamReader("ajto.txt");
while(!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    haladas.Add(new adatok(sor));
}
olvas.Close();

Console.WriteLine("2. feladat");
//Console.WriteLine("Az elso belépő {0}", haladas[0]);
//Console.WriteLine("Az utolsó kilépő {0}");
List<string> utolso = new List<string>();

for (int i = 0; i < haladas.Count; i++)
{
    Console.WriteLine("Az első belépő: {0}", haladas[i].azonosito[0]);
    break;
}
for (int i = 0; i < haladas.Count; i++)
{
    utolso.Add(haladas[i].azonosito);
    
    
}
for(int i= 0; i < utolso.Count;i++)
{
    Console.WriteLine("Az utolsó belépő: {0}", utolso[i-1]);
}
Console.WriteLine();
//3. feladat
List<string> azonositottak = new List<string>();
for(int i = 0;i < haladas.Count; i++)
{
    azonositottak.Add(haladas[i].azonosito);
 
}
StreamWriter ir = new StreamWriter("athaladas.txt");
ir.WriteLine(azonositottak);
ir.Close();

Console.WriteLine("4. feladat");

List<string> dbszam = new List<string>();

for (int i = 0; i < haladas.Count; i++)
{
    if (haladas[i].irany == "be")
    {
        dbszam.Add(haladas[i].azonosito);
    }
      
}
for (int i = 0;i < dbszam.Count; i++)
{
    Console.WriteLine("A végén a társalgóban voltak {0}", dbszam[i]);
    break;
}
Console.WriteLine();
Console.WriteLine("5.feladat");
Console.WriteLine();
Console.WriteLine("6.feladat");

Console.Write("Adja meg a személy azonosítóját!  ");

string beker = Console.ReadLine();
int szam = 0;
for (int i = 0; i < haladas.Count; i++)
{
    if (haladas[i].azonosito == beker)
    {
        szam++;
    }
}
Console.WriteLine();
Console.WriteLine("7. feladat");
List<string> idopontok = new List<string>();


for (int i = 0; i < haladas.Count; i++)
{
    if (haladas[i].idopont == beker)
    {
        idopontok.Add(haladas[i].idopont);

    }
}
for(int i = 0;i<idopontok.Count;i++)
{
    Console.WriteLine(idopontok[i]);
}