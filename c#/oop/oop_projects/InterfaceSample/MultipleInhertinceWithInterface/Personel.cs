using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInhertinceWithInterface
{
    //c# çoklu miras özelliğini interface kullanarak sağlar
    public class Personel : IKisi, ICalisan
    {
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public string Adres { get ; set ; }
        public int ID { get ; set ; }
        public int CalismaSuresi { get ; set ; }
    }
}
