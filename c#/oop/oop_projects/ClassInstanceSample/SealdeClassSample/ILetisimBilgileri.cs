using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdeClassSample
{
    public class ILetisimBilgileri : Kisi
    {
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        //sealed sadece classlar için değil metodlar için de kullanılır
        public sealed override string KisiBİlgileriniYaz()
        {
            string retVal = string.Empty;

            retVal = $"{base.KisiBİlgileriniYaz()}\n" +
                $"Adres : {Adres}\n" +
                $"Telefon : {Telefon}\n" +
                $"Email : {Email}";
            return retVal;
        }
    }
}
