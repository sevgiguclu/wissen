using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdeClassSample
{
    //Sealed anahtar sözcüğü, kendisinden örnek alınabilir fakat miras verilemez anlamına gelir. 
    // Class sealed olarak işaretlenirse bu class'tan inheritance alınamz!!!. Ancak instance alınarak kullanılabilir.....
    public sealed class Kitap : BaseKitap
    {
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public string ISBN { get; set; }
        public string YazarAdi { get; set; }

        public override void GetLog()
        {
            Console.WriteLine("Kitap Classı log metodu");
        }

        public override void GetUser()
        {
            Console.WriteLine("Kitap Class Kullanıcı Bilgileri");
        }
    }
}
