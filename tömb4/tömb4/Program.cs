

int[] tombKeszit(int darab,int legkisebb,int legnagyobb)
{
    int[] tomb=new int[darab];
    Random rand = new Random();

    for(int i=0;i<tomb.Length;i++)
    {
        tomb[i]=rand.Next(legkisebb,legnagyobb+1);
    }



    return tomb;
}
int[] szamok=tombKeszit(1000, 100, 999);

int a =0;
int b =0;
for(int i=0; i<szamok.Length;i++)
{
    if (szamok[i] % 2 == 0)
    {
        a += 1;
    }
    else { b += 1; }
}
Console.WriteLine(a);
Console.WriteLine(b);


bool vanEgyenloSzomszedos=false;
for(int i=1;i<szamok.Length;i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vanEgyenloSzomszedos = true;   
        //break;
        Console.WriteLine("egyenlő: {0}. és {1}, {2} = {3}", i - 1, i, szamok[i - 1], szamok[i]);
    }
}
if(vanEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!");
}

void szakasz2(int[] szamTomb)
{
    int kezd =0;
    int veg = 0;
    int MaxKezd = 0;
    int MaxVeg = 0;

    for(int i=1;i<szamTomb.Length;i++)
    {
        if (szamTomb[i - 1] < szamTomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if(veg-kezd+1>MaxVeg-MaxKezd+1)
            {
                MaxVeg = veg;
                MaxKezd = kezd;
            }
            kezd = i;
        }
    }

    Console.WriteLine("A legnagyobb növekvő számsorozat: ", MaxVeg - MaxKezd);
    for(int i=MaxKezd;i<MaxVeg+1;i++)
    {
        Console.Write("{0}, ", szamTomb[i]);
    }
    Console.WriteLine();
}
szakasz2(szamok);
//hf csinaljunk fuggveny ami a legnagyobb csokenö sorozatot adja vissza és nem szigoruan csokennő