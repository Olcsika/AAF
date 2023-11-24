using System.ComponentModel.Design;
bool kezdo = true;
while (kezdo)
{





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

    Console.WriteLine("A játékos lapjainak összege: {0}", summ2);

    //jaték

    Console.WriteLine("A dealer lapjai: {0}, ?", dealer[0]);
    Console.WriteLine("Mit szeretne tenni? (stand, hit)");
    string dontes = Console.ReadLine();

    while (dontes != "")
    {
        if (dontes == "igen")
        {
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
        }

        if (dontes == "stand")
        {
            Console.WriteLine("Az ön lapjai: {0}", summ2);
            Console.WriteLine("Dealer lajai: {0}", summ);



            if (summ > summ2)
            {
                Console.WriteLine("A dealer nyert.");
                break;
            }
            else if (summ2 == summ)
            {
                Console.WriteLine("Draw.");
                break;
            }
            else if (summ2 > summ)
            {
                Console.WriteLine("Ön nyert.");
                break;
            }
        }



        if (dontes == "hit")
        {
            player.Add(rand.Next(1, 12));
            summ2 = player.AsQueryable().Sum();
        }


        Console.WriteLine("Az ön lapjai összege: {0}", summ2);
        if (summ2 == 21)
        {
            Console.WriteLine("BLACKJACK");
            break;
        }

        if (summ2 > 21)
        {
            Console.WriteLine("BUST");
            break;
        }

        Console.WriteLine("Mit szeretne tenni? (stand, hit)");
        dontes = Console.ReadLine();
    }

    Console.WriteLine("Szeretne mégegy kört? (igen, nem)");
    dontes = Console.ReadLine();

    if (dontes == "igen")
    {
        dealer.Clear();
        player.Clear();
        kezdo = true;
        Console.WriteLine("---------------------------");
    }
    else
    {
        Console.WriteLine("Rendben. Viszlát!");
        kezdo = false;
    }
}