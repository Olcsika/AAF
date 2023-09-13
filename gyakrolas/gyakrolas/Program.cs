using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakrolas
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            while (szam < 999999)
            {
                Console.Write("Kérek egy számot: ");
                
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam >10) 
                {
                    Console.WriteLine("A szám egy jegyű");
                }
                else if (szam > 100)
                {
                    Console.WriteLine("A szám kettő jegyű");
                }
                else if (szam > 1000)
                {
                    Console.WriteLine("A szám három jegyű");
                }
                else if (szam > 10000)
                {
                    Console.WriteLine("A szám négy jegyű");
                }
         
              
                else 
                {
                    Console.WriteLine("A szám hat jegyű");
                }
            }
        }
    }
}
