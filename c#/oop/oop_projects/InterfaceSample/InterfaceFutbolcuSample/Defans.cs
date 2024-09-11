using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFutbolcuSample
{
    public class Defans : IFutbolcu
    {
        [Display(Name ="Adı Soyadı")]
        public string AdSoyad { get ; set ; }
        [Display(Name = "Forma Numarası")]
        public int FormaNumarasi { get ; set ; }

        private byte _sutGucu;//field oluşturduk

        [Display(Name = "Şut Gücü")]
        public byte SutGucu
        {//field değerini diğer sınıflarda kullanabilmek için iletişime açtık diyebiliriz
            get { return _sutGucu; }
            set {
                if(value > 70)
                {
                    _sutGucu = 70;
                    MessageBox.Show("Bir defans oyuncusu şut gücü en gfazla 70 olabilir.\n Şut gücü 70 olarak ayarlandı!!!!");
                }
                else
                {
                    _sutGucu = value;
                }
            
            }
        }

        [Display(Name = "Reflex")]
        public byte Refleks { get; set; }

        [Display(Name = "Agresiflik")]
        public byte Agresiflik { get; set; }

        [Display(Name = "Dayaniklilik")]
        public byte Dayaniklilik { get; set; }

        [Display(Name = "Sol Ayak Mı")]
        public bool SolAYakMi { get; set; }

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
