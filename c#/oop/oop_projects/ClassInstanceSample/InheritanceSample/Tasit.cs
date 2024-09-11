using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    //Base Class(Temel Sınıf) : Türetilecek sınıfların ortak özelliklerinin ortak metot ya da fonksiyonların bulunduğu sınıf
    public class Tasit
    {

        public Tasit() //Constructor (Yapıcı Metot)
        {
            Console.WriteLine("Taşıt Constructor()");
            MaximumHiz = 200;
        }

        //200 burda opsiyonel paremetredir , sayı girilmezse 200 kabul edilecek
        public Tasit(int maxHiz = 200) //Constructor (Yapıcı Metot)
        {
            Console.WriteLine("Taşıt Paremetre Alan Constructor()");
            MaximumHiz = maxHiz;
        }


        public int ID { get; set; }
        public int Kapasite { get; set; }
        public int MaximumHiz { get; set; }
        protected int TekerSayisi { get; set; }//sadece miras alınan sınıfta kullanılabilir, instance alınca kullanılamaz 


    }
}
