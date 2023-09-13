using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Kérek egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine("A bekért szöveg: "+szoveg);
            szoveg=" ";
            while(szoveg!="")
            {
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();
            }


            //HF: szavak bekér üres végjelig.
            //összegyüjtve egy változóban, valahogy elválasztva 

            Console.Write("Kérek egy egész számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szám négyzete: " + szam * szam+1);
            */

            Console.Write("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
       
            for (int i = 0; i < szam; i++)
            {
                Console.Write("kérek egy szöveget: "+(i+1)+". " );
                Console.ReadLine();
                
            }
        

            


        }
    }
}
