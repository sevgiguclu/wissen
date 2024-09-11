using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    //Bir abstract Class'tan instance alınamaz!!
    public abstract class GeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public abstract string AlanHesapla();
        public abstract void CevreHesapla();
    }
}
