
bool jo = false;
while (!jo)
{
    jo = true;
    Console.Write("Mit váltasak át? (pl: 12kg) :");
    string be = Console.ReadLine();

    string[] darab = be.Split(" ");
    if(darab.Length!=2)
    {
        jo = false;
        continue;
    }
    double szam = 0;
    try
    {
        szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("Nem jó formátum! Legyen ilyen : 12,2kg");
        jo = false;
        continue;
    }
    Console.WriteLine(szam);
}
