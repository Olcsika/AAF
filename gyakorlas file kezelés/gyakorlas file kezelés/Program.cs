﻿//kérjunk be szavakat és ezek szavak legyenek ne legyen benne szoköz stb és ezeket szavanként irjuk bele egy fileba
string betuk = "qwertzuiopőúöüóűáélkjhgfdsaíyxcvbnm-";
string beSzo = "mindegymi";

string gyujto = "";
while(beSzo!="")
{
    bool joSzo = true;

    Console.Write("Kérek egy szót: ");
    beSzo = Console.ReadLine();
    for (int i = 0; i < beSzo.Length; i++)
    {
        if (betuk.IndexOf(beSzo[i]) == -1)
        {
            joSzo = false;
            Console.WriteLine("Ez nem jo szó! ");
            break;
        }
    }
    if (joSzo)
    {
        gyujto += beSzo+" ";
    }
}
Console.WriteLine(gyujto);

Console.WriteLine();

string[] darabok=gyujto.Trim().Split(' ');

StreamWriter ir= new StreamWriter("szavak.txt");
for (int i = 0;i < darabok.Length;i++) 
{
    ir.WriteLine(darabok[i]);
}
ir.Close();

File.AppendAllLines("szavak2.txt", darabok);



