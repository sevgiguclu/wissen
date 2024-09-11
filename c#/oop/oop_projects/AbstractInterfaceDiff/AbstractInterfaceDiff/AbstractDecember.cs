using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    public class AbstractDecember : Month
    {
        public AbstractDecember() //constructor metod , yazılmazsa alt sınıfınkini çalıştırır
        {
            Console.WriteLine("December Sınıfı Yaratıldı");
        }

        //abstract metodları implement etmek zorundayım
        public override void MonthName()
        {
            Console.WriteLine("December");
        }

        public override void MonthNumber()
        {
            Console.WriteLine("12. Month");
        }

        //virtual metod olduğu için istersem ezerim istersem aynı adda ezmeden kullanırım
        //public override void DayCount()
        //{
        //    Console.WriteLine("31gün");
        //}

        public void DayCount()
        {
            Console.WriteLine("31gün");
        }
    }
}
