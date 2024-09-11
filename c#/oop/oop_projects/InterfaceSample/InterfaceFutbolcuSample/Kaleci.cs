using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFutbolcuSample
{
    public class Kaleci : IFutbolcu
    {
        [Display(Name = "Adı Soyadı")]
        public string AdSoyad { get; set; }
        [Display(Name = "Forma Numarası")]
        public int FormaNumarasi { get; set; }


        [Display(Name = "Şut Gücü")]
        public byte SutGucu { get; set; }


        [Display(Name = "Reflex")]
        public byte Refleks { get; set; }

        [Display(Name = "Agresiflik")]
        public byte Agresiflik { get; set; }
        [Display(Name = "Dayaniklilik")]
        public byte Dayaniklilik { get; set; }

        [Display(Name = "Sol Ayak Mı")]
        public bool SolAYakMi { get; set; }

        [Display(Name = "Elle Top Kontrolü")]
        public byte ElleTopKontrolu { get; set; }

        public string Sakatlandi()
        {
            return "Sakatlandı";
        }

        public string SutCek()
        {
            return "Uzaktan Şut Çekti!!!";
        }

        public string TopKurtar()
        {
            return "Karşı takım ouuncusunu markaja aldı!!!!";
        }

        public override string ToString()
        {
            return $"{FormaNumarasi} - {AdSoyad}";
        }
    }
}
