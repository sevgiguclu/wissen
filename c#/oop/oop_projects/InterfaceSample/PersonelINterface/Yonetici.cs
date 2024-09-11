using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelINterface
{
    public class Yonetici : IKisi
    {
        public int ID { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public string Departman { get ; set ; }
        public double Maas { get ; set ; }

        public int BagliPersonelSayisi {  get ; set ; }
        public string getInfo()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"ID : {ID}\n");
            strBuilder.Append($"İsim : {Ad} {Soyad}\n");
            strBuilder.Append($"Departman : {Departman}\n");
            strBuilder.Append($"Maaş : {Maas}\n");
            strBuilder.Append($"Bağlı Personel Sayısı : {BagliPersonelSayisi}");
            return strBuilder.ToString();
        }
    }
}
