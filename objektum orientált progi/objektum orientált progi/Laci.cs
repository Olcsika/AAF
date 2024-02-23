using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektum_orientált_progi
{
    internal class Laci
    {
        
        string baratno = "";
        public void sug()
        {
            Console.WriteLine("Ki-fejezés!");
        }
        public Laci(string baratno)
        {
            this.baratno = baratno;

        }
    }
}
