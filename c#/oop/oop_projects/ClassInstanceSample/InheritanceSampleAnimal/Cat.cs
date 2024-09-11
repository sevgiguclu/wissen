using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public enum HouseType
    {
        small,
        regular,
        big
    }

    public class Cat:Animal
    {
        
        public Cat()
        {
            Console.WriteLine("Class Cat COnstructor");
        }

        public string CatHouse { get; set; }

        public double CatHousePrice(HouseType houseType)
        {
            double result = 0.0;
            switch (houseType)
            {
                case HouseType.small:
                    result = 300;
                    break;
                case HouseType.regular:
                    result = 500;
                    break;
                case HouseType.big:
                    result = 1000;
                    break;
            }

            return result;
        }

    }
}
