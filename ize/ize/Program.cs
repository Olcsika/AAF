using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ize
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 95; i++) 
            { 
                if (i % 5 == 0)
                { 
                    Console.WriteLine(i + " "); 
                } 
            }
            Console.WriteLine();

            for (int i = 10; i <= 95; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            

        }
    }
}
