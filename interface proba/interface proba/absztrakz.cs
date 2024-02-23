using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_proba
{
    internal abstract class absztrakz:Interface1
    {
        public int szam()
        {
            return 100000;
        }
        public abstract void kiir();

        int privatTusko = 0;
        public int tusko
        {
            get { return 0; }
            set { privatTusko = value; }
        }
    
    }
}
