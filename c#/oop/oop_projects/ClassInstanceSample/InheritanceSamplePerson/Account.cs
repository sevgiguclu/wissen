using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamplePerson
{
    public class Account : Human
    {
        public bool MaasBilgileriniGorebilir { get; set; }
        public bool MaasBilgileriniDegistirebilir { get; set; }

        public void BilgileriGoster()
        {
            string info = $"{AdSoyad} isimli Muhasebe Birimi Personelinin : \n" +
                $"Doğum Tarihi : {DogumTarihi}\n" +
                $"Cinsiyet : {(Cinsiyet ? "Erkek" : "Kadın")}\n" +
                $"Kilo :{Kilo}  -  Boy : {Boy}\n" +
                $"Ehliyet : {(EhliyetVarMi ? "Var" : "YOk")}\n" +
                $"Sağlık Sorunu : {(SaglikSorunuVarMi ? "Var" : "Yok")}\n" +
                $"Aldığı Ücret : {AldigiUcret}\n" +
                $"Yetkileri : \n" +
                $"Maaş Bilgilerini {(MaasBilgileriniGorebilir ? "Görebilir" : "Göremez")}\n" +
                $"Maaş Bilgilerini {(MaasBilgileriniDegistirebilir ? "Değiştirebilir" : "Değiştiremez")}";
            Console.WriteLine(info);
        }
    }
}
