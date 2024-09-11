using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Yonetici : Kisi
    {
        public Yonetici() 
        {
            Console.WriteLine("Yönetici Sınıfı Oluşturuldu....");
        }

        public int BagliPersonelSayisi {  get; set; }

        public string getYoneticiInfo()
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
