// See https://aka.ms/new-console-template for more information
Console.Write("Mit váltsak át? (pl:12kg) :");
string be = Console.ReadLine();
string[] darab = be.Split(' ');

try
{
    double szam = Convert.ToDouble(darab[0]);
}
catch
{
    throw;
}



