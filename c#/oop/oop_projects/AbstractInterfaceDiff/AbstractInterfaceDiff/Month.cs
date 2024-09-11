using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    //Bir abstract Class'tan instance alınamaz!!
    public abstract class Month
    {
        public Month()
        {
            Console.WriteLine("Yılın AYlarını Temsil eden Abstract Sınıf");
        }

        public void YearMonthCOunt()
        {
            Console.WriteLine("Yıl 12 aydan oluşur");
        }

        //Abstract olarak işaretlenen metodların bodysi olmaz , üst sınıfta implement edilir
        public abstract void MonthName();
        public virtual void DayCount()//virtual olduğu için üst sınıfta istersem implemet ederim istersem etmem
        {
            Console.WriteLine("30gün");
        }
        public abstract void MonthNumber();

    }
}
