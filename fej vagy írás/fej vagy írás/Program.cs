List<string> lista1 = new List<string>();
List<string> lista2 = new List<string>();

StreamReader olvas = new StreamReader("kiserlet.txt");
olvas.ReadLine();
while (!olvas.EndOfStream)
{
    lista1.Add(olvas.ReadLine());
    

}
for (int i = 0; i < lista1.Count; i++)
{
    Console.WriteLine(lista1[i]);
}
olvas.Close();

string[] adatok =File.ReadAllLines("kiserlet.txt");
for (int i = 0;i < adatok.Length;i++)
{
    lista2.Add(adatok[i]);
}

for(int i = 0;i<lista2.Count ; i++)
{
    Console.WriteLine(lista2[i]);
}


