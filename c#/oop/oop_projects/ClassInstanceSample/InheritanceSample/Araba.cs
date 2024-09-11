using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    //Derived Class(Türemiş Sınıf)
    public class Araba: Tasit // ":" ile hangi sınıftan miras alacağı belirlenir
    {

        //:base türediğimiz sınıfı temsil eder, bize türediğimiz sınıfın hangi constructorını çalıştıracağımızı söyler, default davranış paremetresiz constructor çalıştırır 
        public Araba():base(150)
        {
            int tekerSayisi = this.TekerSayisi;//protected özelliği sadece miraz aldığım bu sınıfta kullanabilirim
            Console.WriteLine("Araba Constructor");
            ID = 1;
            Kapasite = 200;
            TekerSayisi = 4;
            MaximumHiz = 400;
            KapiSayisi = 2;
        }

        public Araba(int id, int kapi)
        {
            Console.WriteLine("Araba Constructor - Parametre alan COnstructor");
            ID = id;
            KapiSayisi = kapi;

        }

        public int KapiSayisi { get; set; }
    }
}
