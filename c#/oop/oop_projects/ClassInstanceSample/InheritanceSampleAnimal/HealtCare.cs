using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class HealtCare
    {
        public HealtCare() {
            Console.WriteLine("Muayne Bilgileri");

        }

        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public string GetInfo
        {
            get
            {
                string returnVal = $"Date : {this.Date.ToLongDateString()} \t Notes: {Notes}";
                return returnVal ;
            }
        }

    }
}
