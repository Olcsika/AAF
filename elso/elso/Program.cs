using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helló Világ!!");
            Console.WriteLine("Helló Világ!!"[4]);
            double szam = -8.32332323;
            Console.WriteLine(szam);
            string l = "Alma";
            Console.WriteLine(l);
            char z = 'o';
            Console.WriteLine(z);
            Console.WriteLine((char)(z + 2));


            Console.WriteLine(10 / 3);
            int i = 0;
            ++i;
            Console.WriteLine(i);
            int a;
            a = 5;
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }

            else if (a < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("egyenlő");
            }
            switch (a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("keto");
                    break;
                case 3:
                    Console.WriteLine("Háom");
                    break;
                case 4:
                    Console.WriteLine("Négy");
                    break;
                default:
                    Console.WriteLine("Valami más");
                    break;
            }
            double szam1 = 1;

            while (szam1 < 5)
            {
                Console.WriteLine(szam1);
                szam1 += 0.1;
            }
            do
            {
                szam1 -= 0.2;
                Console.WriteLine(szam1);
            }
            while (szam1 > 2);

            char betu = 'a';
            
            while(betu<='z')
            {
                Console.Write(betu);
                betu = (char)(betu + 1);
            }
            Console.WriteLine();

            int szam32 = 32;
            while(szam32<=250)

            {
                Console.Write((char)szam32 + " ");
                if (szam32 % 8 == 7)
                {
                    Console.WriteLine();
                }
                szam32++;

            }
            Console.WriteLine();


            for (int k = 0; k <= 10; k++) 
            {
                Console.WriteLine(k);
            }
            int szamol = 0;
            for(int g=1;g<=15;g++)
            {
                szamol += g;
                
            }
            Console.WriteLine(szamol);

            for (int d =9; d>0;d--)
            {
                Console.WriteLine(d)
;           }
            for(int c =0; c<10; c++)
            {
                Console.WriteLine(9 - c);
            }

            

        }
    }
}
