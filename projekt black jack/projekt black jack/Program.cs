List<int> dealer = new List<int>();
List<int> player = new List<int>();

Random rand = new Random();

int szamok = rand.Next(104);

for (int i = 0; i < szamok; i++)
{
    if (dealer.Count < 2)
    {
        dealer.Add(rand.Next(1, 12));
    }
    else
    {
        break;
    }
}

for (int i = 0; i < szamok; i++)
{
    if (player.Count < 2)
    {
        player.Add(rand.Next(1, 12));
    }
    else
    {
        break;
    }
}

Console.WriteLine();

foreach (int i in dealer)
{
    Console.WriteLine("Az osztó számai : {0}", i);
}

Console.WriteLine();

foreach (int i in player)
{
    Console.WriteLine("A"i);
}

//Összeadása elemeknek pl: 2+2=4

int sum1 =dealer.AsQueryable().Sum();
Console.WriteLine();
Console.WriteLine(sum1);

int sum2=player.AsQueryable().Sum();
Console.WriteLine();
Console.WriteLine(sum2);

