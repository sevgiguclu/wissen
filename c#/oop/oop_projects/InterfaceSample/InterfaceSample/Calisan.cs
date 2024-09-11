using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Calisan : Kisi
    {
        public Calisan() 
        {
            Console.WriteLine("Çalışan Sınıfı Oluşturuldu...");
        }

        public int YoneticiID {  get; set; } 
        
        public string getCalisanInfo ()
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
