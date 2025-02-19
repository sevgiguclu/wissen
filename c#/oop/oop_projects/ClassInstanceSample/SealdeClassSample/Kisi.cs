using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdeClassSample
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public int Yas { get; set; }

        //virtual'ı kullanmazsam , alt sınıflar bu metodu override edemez
        public virtual string KisiBİlgileriniYaz()
        {
            string retVal = string.Empty;
            retVal = $"Ad Soyad : {Ad} {Soyad}\n" +
                $"Cinsiyet {(Cinsiyet ? "Erkek" : "Kadın")}\n" +
                $"Yaş : {Yas}";
            return retVal;
        }

    }
}
