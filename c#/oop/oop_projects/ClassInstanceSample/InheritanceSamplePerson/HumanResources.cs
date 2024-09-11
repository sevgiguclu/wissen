using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamplePerson
{
    public class HumanResources:Human
    {
        public bool IseAlabilir { get; set; }
        public bool UcretBelirleyebilir { get; set; }
        public bool CalismaSaatiBelirleyebilir { get; set; }

        public HumanResources(string adsoyad, DateTime dogumTarihi, bool cinsiyet, double kilo, double boy, bool ehliyetVarMi, bool saglikSorunuVarMi, decimal aldigiUcret, bool iseAlabilir, bool ucretBelirleyebilir, bool calismaSaatiBelirleyebilir)
        {
            AdSoyad = adsoyad;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            Kilo = kilo;
            Boy = boy;
            EhliyetVarMi = ehliyetVarMi;
            SaglikSorunuVarMi = saglikSorunuVarMi;
            AldigiUcret = aldigiUcret;
            IseAlabilir = iseAlabilir;
            UcretBelirleyebilir = ucretBelirleyebilir;
            CalismaSaatiBelirleyebilir = calismaSaatiBelirleyebilir;

            EkranaYaz();
        }

        private void EkranaYaz()
        {
            string info = $"{AdSoyad} isimli Insan Kaynakları Birimi Personelinin : \n" +
               $"Doğum Tarihi : {DogumTarihi}\n" +
               $"Cinsiyet : {(Cinsiyet ? "Erkek" : "Kadın")}\n" +
               $"Kilo :{Kilo}  -  Boy : {Boy}\n" +
               $"Ehliyet : {(EhliyetVarMi ? "Var" : "YOk")}\n" +
               $"Sağlık Sorunu : {(SaglikSorunuVarMi ? "Var" : "Yok")}\n" +
               $"Aldığı Ücret : {AldigiUcret}\n" +
               $"Yetkileri : \n" +
               $"İşe {(IseAlabilir ? "Alabilir" : "Alamaz")}\n" +
               $"Ücret {(UcretBelirleyebilir ? "Belirleyebilir" : "Belirleyemez")}\n" +
               $"Çalışma Saati {(CalismaSaatiBelirleyebilir ? "Belirleyebilir" : "Belirleyemez")}";
            Console.WriteLine(info);
        }
    }
}
