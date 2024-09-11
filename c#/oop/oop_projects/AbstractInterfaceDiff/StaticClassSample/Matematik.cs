using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public class Matematik
    {

        public Matematik()//her zman tetiklenir
        {
            Pi = 7;
        }

        static Matematik()//static constructor sadece ilk instance alındığında çalışır,önce static constructor çalışır
        {
            Pi = 3.1415;
        }


        ////static class,field ve propertylerde instance etmeye gerek yok, örneğin Math sınıfı , örneğin Console sınıfı


        //public static double Toplam(double x, double y)
        //{
        //    return x + y;
        //}

        ////static metod olmadığı için önce instance almam gerekiyor
        ////static olmayan bir metotta static metot kullanabilirim
        //public double Toplamlar(int ustSinir, double x, double y)
        //{
        //    double sonuc = 0;
        //    for (int i = 0; i < ustSinir; i++)
        //    {
        //        sonuc += Toplam(x, y);
        //    }
        //    return sonuc;
        //}


        ////static bir metodun içinde static olmayan bir metod kullanamam, hata verir
        //public static void AltToplamler(int ustSinir, double x, double y)
        //{
        //    double sonuc = Toplamlar(10, 20, 30);
        //}


        public static double Pi = 3.14;

        public void  PiDegistir(double value)
        {
            Pi = value;
        }

    }
}
