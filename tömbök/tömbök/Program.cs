
void kiir(int[]tomb)
{
    foreach (int i in tomb)
    {
        Console.WriteLine("{0}. szám", i);
    }
}

int[] szamok = new int[100];   
for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = i+1;
}
Console.WriteLine(szamok);
foreach (int i in szamok)
{
    Console.WriteLine("{0}. szám",i);
}
for (int i = 0;i < szamok.Length;i++)
{
    szamok[i] = szamok[i]*2;
    
}
kiir(szamok);

//hazi feladat a szorzo tabla egyes tol 10 ig megvalositása 2 dimenzios tomben és kiirasa tablazat szeruen.