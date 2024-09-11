using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Animal
    {
        /// <summary>
        ///  animal class constructor
        /// </summary>
        public Animal() //constructor (yapıcı metod) 
        {
            Console.WriteLine("animal class instance");
        }

        /// <summary>
        /// animalType alan constructor
        /// </summary>
        /// <param name="animalType"> animalType string değer alır</param>
        public Animal(string animalType)//parametre alan constructor (yapıcı metod) 
        {
            Console.WriteLine(animalType);
        }

        private string animalType;//field
        //fieldlar yazmasak dahi default olarak privatetir

        //eski kullanım
        //public string getAnimalType() { return animalType; }
        //public void setAnimalType(string animal_Type) 
        //{
        //    animalType = animal_Type;
        //}

        //prop yazıp iki kere taba basarak da get ve set oluşturabilirsin
        //public string AnimalType { get => animalType; set => animalType = value; }//field ile alışır
        //public string AnimalType { get; set; }//field tanımlamasak da olur

        //bu kullanım kontrol yapılacağında tercih edilir,property tanımlama
        public string AnimalType {
            get
            {
                if (!string.IsNullOrEmpty(animalType))
                    return animalType;
                else
                    return "animal type boş geldi";
            }

            set
            {
                animalType = value;
            }
        }

        //property tanımladık
        public int Speed { get; set; }

        ~Animal() {//yıkıcı metot
            Console.WriteLine("animal sınıfı bellekten kaldırıldı..");
        }




    }
}
