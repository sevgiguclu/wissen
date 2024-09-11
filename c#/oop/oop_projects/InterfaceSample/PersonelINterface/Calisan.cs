using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelINterface
{
    
    public class Calisan : IKisi
    {
        //interfaceden sınıf türettiğimde , interface özelliklerini implement etmem gerekiyor
        public int ID { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public string Departman { get ; set ; }
        public double Maas { get ; set ; }

        public int YoneticiID {  get ; set ; }
        public string getInfo()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"ID : {ID}\n");
            strBuilder.Append($"İsim : {Ad} {Soyad}\n");
            strBuilder.Append($"Departman : {Departman}\n");
            strBuilder.Append($"Maaş : {Maas}\n");
            strBuilder.Append($"Bağlı OLduğu Yönetici ID : {YoneticiID}");
            return strBuilder.ToString();
        }
    }
}
