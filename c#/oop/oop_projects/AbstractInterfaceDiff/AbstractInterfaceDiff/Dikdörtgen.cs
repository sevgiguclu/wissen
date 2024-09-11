using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    public class Dikdörtgen : GeometrikSekil
    {
        public override string AlanHesapla()
        {
            return $"Dikdörtgenin Alanı : {Genislik * Yukseklik}";
        }

        public override void CevreHesapla()
        {
            Console.WriteLine($"Dikdörtgenin Çevresi : {2 * (Genislik + Yukseklik)}");
        }
    }
}
