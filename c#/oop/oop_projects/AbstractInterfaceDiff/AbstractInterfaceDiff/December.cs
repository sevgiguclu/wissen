using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    public class December : IMonth
    {
        //her ay için mont anem ve mont number değişecek değerler içeriyor , day count da bazıları 30 bazıları 31
        public string MonthName { get ; set ; }
        public int DayCount { get ; set ; }
        public int MonthNumber { get ; set ; }
    }
}
