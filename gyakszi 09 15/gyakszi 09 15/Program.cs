
/*
Console.Write("Kérek egy számot: ");
int szam = Convert.ToInt32(Console.ReadLine());
for  (int i = 0;i<szam;i++)
{
    Console.WriteLine(i * 10);
}
*/
Console.Write("Kérek egy számot: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=a;i++)
{
    for (int k = 1; k < a; k++)
    {
        Console.Write(i * k + "\t");

    }
    Console.WriteLine();

}
for (int k = 1;k < 999; k++)
{
    Console.WriteLine(k+k);

}