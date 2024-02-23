using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzemanyag
{
    internal class adatok
    {
        public DateTime datum;
        public int benzin;
        public int gazolaj;
        double euro = 307.7;
        public adatok(string sor)
        {
            string[] vag= sor.Split(';');
            datum = Convert.ToDateTime(vag[0]);
            benzin = int.Parse(vag[1]);
            gazolaj = int.Parse(vag[2]);
        }

        public int kulonbseg()
        {
            return Math.Abs(benzin -gazolaj);
            
        }
        public double benzinEuro()
        {
            return benzin/euro;
        }
        public double gazolajEuro()
        {
            return gazolaj / euro;
        }
        public string fileba()
        {
            return datum.ToString()+";"+Math.Round(benzinEuro(),2)+";"+Math.Round(gazolajEuro(),2);
        }
    }
}
