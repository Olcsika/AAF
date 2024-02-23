using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    internal class adatok
    {
        public string idopont;
        public string azonosito;
        public string irany;

        public adatok (string sor)
        {
            string[] vag = sor.Split (" ");
            idopont = vag[0]+" " + vag[1];
            azonosito = vag[2];
            irany = vag[3];
        }

    }
}
