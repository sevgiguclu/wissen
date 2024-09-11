using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    public enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    public enum Renkler
    {
        [Display(Name = "Sarı ve Mavi")]
        SariveMavi,
        Sarı,
        Turuncu,
        Kırmızı,
        Mavi,
        Yeşil,
        Siyah,
        Beyaz
    }

    //enum tanımlarken iki nokta üst üste : kullanarak, elemanların hangi veri türünde olacağını belirleyebilirsiniz
    //public enum byte rgb gibi bi kullanım yoktur, sentaks hatası verir
    public enum RGB : byte //byte türünde değerler oluşturmak için miras aldık
    {
        Red = 2, Green = 4, Blue = 8
    }
}
