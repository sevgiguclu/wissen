using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInhertinceWithInterface
{
    public class Yonetici : IKisi, ICalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int ID { get; set; }
        public int CalismaSuresi { get; set; }
    }
}
