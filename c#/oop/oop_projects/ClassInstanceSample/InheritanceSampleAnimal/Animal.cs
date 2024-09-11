using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class Animal
    {
        public Animal() {
            Console.WriteLine("Ortak özleliklerin bulunduğu class");
        }

        #region Properties

        public int FootCount { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public List<HealtCare> HealthCareHistory { get; set; }
        public double Weight { get; set; }

        public string AnimalInfo
        {
            get
            {
                string info = $"FootCOunt : {FootCount}\n" +
                    $"Age : {Age}\n" +
                    $"Weight : {Weight}\n" +
                    $"HelathCare History : {HealthCareHistoryList(HealthCareHistory)}";
                return info;
            }
        }

        #endregion

        #region Procuders

        private string HealthCareHistoryList(List<HealtCare> healthCareHistory)
        {
            /*
                *StringBuilder, sıklıkla değiştirilen metinlerle çalışırken daha yüksek performans sağlayan bir sınıftır.
                *StringBuilder, birden çok kez değiştirilecek olan uzun metinlerin oluşturulması, birleştirilmesi veya değiştirilmesi durumlarında kullanılır. 
            */
            StringBuilder sb = new StringBuilder();
            foreach (HealtCare hc in healthCareHistory)
            {
                sb.Append($"{hc.Date.ToString("yyyy-MM-dd")} - {hc.Notes}");
            }
            return sb.ToString();
        }

        
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }

        public int Run(int minute, int distance, out int cal)
        {
            int result = 0;
            cal = minute * distance / 100;
            result = minute * distance;
            return result;

        }


        /*
         * TimeSpan, iki tarih veya saat arasındaki süreyi temsil eden bir yapıdır (struct).
         * Bu yapı, günler, saatler, dakikalar, saniyeler ve milisaniyeler cinsinden zaman aralıklarını ifade etmek için kullanılır. 
        */
        public TimeSpan Rest(DateTime beginDate, DateTime endDate)
        {

            TimeSpan result;
            result = endDate.Subtract(beginDate);
            return result;

        }
        #endregion
    }
}
