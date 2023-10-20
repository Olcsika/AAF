
// keszit egy fuggveny ami visszaad egy 10000 tagu 4 jegyu pzitiv szamokkal tartalmazó tömbot , keressuk meg a pontosan három tagu szakaszokat amik egymástol maximum 10 távolságra vannak.
int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();

    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }



    return tomb;
}
int[] szamok = tombKeszit(10000, 1000, 9999);
int a = 0;
int b = 0;
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i]<=10)
    {
        a++;
        Console.WriteLine("a");
    }
    else
    {
        Console.WriteLine("a");
    }
}
Console.WriteLine(a);
Console.WriteLine(b);

