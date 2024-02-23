using fejvagyiras;
List<string> dobasok = new List<string>(); 

StreamReader olvas = new StreamReader("kiserlet.txt");
while(!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    if (dobasok[dobasok.Count-1]==sor)
    {
        dobasok[dobasok.Count - 1].db++;
    }
}
olvas.Close();