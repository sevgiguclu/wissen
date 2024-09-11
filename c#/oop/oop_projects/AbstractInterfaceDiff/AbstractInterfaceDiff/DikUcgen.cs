using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    public class DikUcgen : GeometrikSekil
    {
        public override string AlanHesapla()
        {
            return $"Dik Üçgen ALanı : {(Genislik * Yukseklik) / 2}";
        }

        public override void CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            Console.WriteLine($"Dik Üçgenin Çevresi : {hipotenus + Genislik + Yukseklik}");
        }
    }
}
