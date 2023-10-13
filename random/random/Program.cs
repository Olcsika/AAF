
int[] tomb = new int[1000];
for (int i = 0; i < tomb.Length; i++)
{
    Random random = new Random();
    tomb[i] = Convert.ToInt32(random.Next(100,1000));
}
Console.WriteLine(tomb);
//hazi ezer darab szam kész válogassuk szát hogy külön tömb a 2,3,4,5,6 osztható szam + feladat kettő dimenzios tömbe tároljuk