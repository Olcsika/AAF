string szoveg = "Hello Bence!!";
for (int i = 0; i < szoveg.Length; i++)
{
    Console.WriteLine(szoveg[i]);
}
Console.WriteLine();
foreach(char s in szoveg)
{ 
    Console.WriteLine(s); 
}
Console.WriteLine();
for (int i = 0;i < szoveg.Length;i++)
{
    Console.WriteLine(szoveg.Substring(i,1));
}
Console.WriteLine(szoveg.ToUpper());

string[] darab =szoveg.Split(" ");
Console.WriteLine(darab[0] +" "+ darab[1].ToUpper());
Console.WriteLine(szoveg.Substring(0,szoveg.IndexOf(" ")+1)+szoveg.Substring(szoveg.IndexOf(" ")+1).ToUpper());

//hf kérjunk be egy több szobol álló szöveget bármilyne kis nagy betu mindnen  szo kezdobetüje nagy a tobbi kicsi