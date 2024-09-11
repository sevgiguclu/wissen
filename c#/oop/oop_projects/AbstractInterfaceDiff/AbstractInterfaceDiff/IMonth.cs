using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDiff
{
    interface IMonth
    {
        string MonthName { get; set; }
        int DayCount { get; set; }
        int MonthNumber { get; set; }
    }
}
