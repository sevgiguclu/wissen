using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Person
    {
        /*
         * Access Modifiers - Erişim Belirleyiciler
         * private : Aynı class içerisinde erişilebilen değişkenler, fieldlar,metotlar v e fonksiyonları tanımlamak için kullanılır
         * internal : Aynı solution içerisinde erişilebilien değişkenler, fieldlar, metotlar ve fonksiyonları tanımlamak için kullanılır
         * protected : Inherit(Miras ya da kalıtım) yapılarak kullanılan class larda erişilebilen değişkenler , fieldlar, metotlar ve fonksiyonalr tanımlamak için kullanılır
         * public : Genel her projeden erişilebilen değişkenler , fieldlar, metotla ve fonksiyonalrı tanımlamak için kullanılır 
         * internal protected : Aynı solution içerisinde Inherit(Miras ya da kalıtım) yapılarak kullanılan class larda erişilebilen değişkenler , fieldlar, metotlar ve fonksiyonalr tanımlamak için kullanılır
         */

        /*
         * Aynı sınıf içerisnde aynı isimden metod varsa overload , base sınıftan geldiyse override
         * 
         * 
         * 
         */


        public Person() 
        {
            string txt = "Person Sınıfı Başlatıldı!!!!";
            Console.WriteLine(txt);
        }

        public Person(string _personName)
        {
            string txt = $"Person Sınıfı {_personName} ile  Başlatıldı!!!!";
            Console.WriteLine(txt);
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }


        //Read Only Property
        public string Isim
        {
            get { return $"{this.Ad} {this.Soyad}"; }
        }

        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            //polymorhisim durumu : default değerden(toStringin default değeri var base sınıfında) farklı bir işlem yapıcaz
            //return base.ToString();//base hangi sınıf kullanılıyorsa onu temsil eder

            string personInfo =
                $"İsim : {this.Isim}\n" +
                $"Doğum Tarihi : {DogumTarihi}\n" +
                 $"Cinsiyet : {Cinsiyet}\n" +
                  $"Email : {Email}\n" +
                   $"Telefon : {Telefon}\n" +
                    $"Adres : {Adres}";
            return personInfo;
        }

        private string _personInfo;
        public string getPersonInfo//readonly property
        {
            get
            {
                _personInfo =
                        $"İsim : {this.Isim}\n" +
                    $"Doğum Tarihi : {DogumTarihi}\n" +
                     $"Cinsiyet : {Cinsiyet}\n" +
                      $"Email : {Email}\n" +
                       $"Telefon : {Telefon}\n" +
                        $"Adres : {Adres}";
                return _personInfo;
            }
        }

    }
}
