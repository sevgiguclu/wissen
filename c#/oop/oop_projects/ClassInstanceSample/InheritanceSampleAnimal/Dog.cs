using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class Dog:Animal
    {
        public Dog() {
            Console.WriteLine("Dog Class Constructor");
        }

        public int FoodPacketCount { get; set; }
        public double FoodPocketPrice { get; set; }

        public double CalculateFoodPrice(int feedCountDaily)
        {
            double result;
            result = feedCountDaily * (FoodPacketCount * FoodPocketPrice);
            return result;
        }


    }
}
