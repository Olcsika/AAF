using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;

List<int> dealer = new List<int>();
List<int> player = new List<int>();

Random rand = new Random();

int szamok = rand.Next(104);

for (int i = 0; i < szamok; i++)
{
    if (dealer.Count < 2)
    {
        dealer.Add(rand.Next(1, 12));
        bool Jo = true;
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

foreach (int i in dealer)
{
    //Console.WriteLine(i);
}

foreach (int i in player)
{
    //Console.WriteLine(i);
}

//Összeadása elemeknek pl: 2+2=4

int summ = dealer.AsQueryable().Sum();
/*
Console.WriteLine();
Console.WriteLine(summ);
*/
//player változat
int summ2 = player.AsQueryable().Sum();
/*
Console.WriteLine();
Console.WriteLine(summ2);
*/
Console.WriteLine("-----------------------------BLACKJACK-----------------------------");
Console.WriteLine();
Console.WriteLine("A játékos lapjainak összege: {0}", summ2);

//jaték

Console.WriteLine("A dealer lapja: {0}", dealer[0]);
Console.WriteLine("Mit szeretne tenni? (stand, hit)");
string dontes = Console.ReadLine();

while (dontes != "")
{


    if (dontes == "stand")
    {
        Console.WriteLine("Az ön lapjai: {0}", summ2);
        Console.WriteLine("Dealer lajai: {0}", summ);


        if (summ > summ2)
        {
            Console.WriteLine("A dealer nyert.");
            Console.WriteLine("-----------------");
        }
        else if (summ2 == summ)
        {
            Console.WriteLine("Draw.");
            Console.WriteLine("-----------------");
        }
        else if (summ2 > summ)
        {
            Console.WriteLine("Ön nyert.");
            Console.WriteLine("-----------------");
        }
        else if (summ2 > 21)
        {
            Console.WriteLine("A dealer nyert.");
            Console.WriteLine("-----------------");
        }
        else
        {
            break;
        }
    }



    if (dontes == "hit")
    {
        player.Add(rand.Next(1, 12));
        summ2 = player.AsQueryable().Sum();
    }
    foreach (int i in player)
    {
        //Console.WriteLine("{0}", i);
    }

    Console.WriteLine("Az ön lapjai összege: {0}", summ2);
    Console.WriteLine("A dealer lapjai összege: {0}", summ);
    if (summ2 == 21)
    {
        Console.WriteLine("BLACKJACK");
        Console.WriteLine("Ön nyert.");

        break;
    }

    if (summ2 > 21)
    {
        Console.WriteLine("BUST");
        Console.WriteLine("Ön vesztet.");
        break;
    }

    Console.WriteLine("Mit szeretne tenni? (stand, hit)");
    dontes = Console.ReadLine();
}

Console.WriteLine("Szeretne mégegy kört? (igen, nem)");
string kor = Console.ReadLine();

if (kor == "igen")
{

    //Console.WriteLine("Mit szeretne tenni? (stand, hit)");
    //dontes = Console.ReadLine();

}
else if (kor == "nem")
{
    Console.WriteLine("Rendben. Viszlát!");
}
else
{
    Console.WriteLine("Érvénytelen válasz!");
}