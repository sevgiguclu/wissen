using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Kisi
    {
        public Kisi() 
        {
            Console.WriteLine("Kişi Sınıfı Oluşturuldu");
        }

        public int ID { get; set; }   
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        public double Maas {  get; set; }
        public string Departman {  get; set; }
    }
}
