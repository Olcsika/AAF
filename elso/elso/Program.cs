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
            Console.WriteLine((char)(z+2));
            

            Console.WriteLine(10 / 3);
            int i = 0;
            ++i;
            Console.WriteLine(i);
            int a;
            a = 5;
            if(a>2)
            {
                Console.WriteLine("Nagyobb");
            }

            else if(a<2)
            {
                Console.WriteLine("Kisebb");
            }
            else if(a%2 ==0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("egyenlő");
            }
            switch(a)
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
        }
    }
}
