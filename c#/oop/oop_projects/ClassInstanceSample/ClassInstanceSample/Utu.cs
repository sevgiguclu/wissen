using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Utu
    {
        //boş bir constructor
        public Utu() {
            Console.WriteLine("Hello ütüüü :) ");
        }

        //parametreli constructor
        public Utu(string marka,string renk,int sicaklik,bool kazanliMi) 
        { 
            //this kullanmak zorunda değiliz
            this.Marka = marka;
            this.Renk = renk;
            Sicaklik = sicaklik;//propertylerin set metodları çalışır
            KazanliMi = kazanliMi;

            //get metodları çalışır
            string str = $"ütü nesnesi aşağıdaki bilgiler ile oluşturudu : \n"+
                $"Marka: {Marka} \n"+
                $"Renk: {Renk} \n"+
                $"Sıcaklık: {Sicaklik} \n"+
                $"Kazanlı mı?: {(KazanliMi? "Var" : "Yok")} \n";
            Console.WriteLine(str);

        }

        public Utu(string marka)
        {
            Marka = marka;
            string utuBilgileri =
                $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" +
                $"Marka : {this.Marka}\n";
            Console.WriteLine(utuBilgileri);
        }

        public void Isın(int derece)
        {
            Sicaklik += derece;
            Console.WriteLine($"Ütünün sıcaklığı arttı. Şu anki sıcaklı : {Sicaklik}");
        }

        public string Marka { get; set; }
        public string Renk { get; set; }
        public int Sicaklik { get; set; }
        public bool KazanliMi { get; set; }


    }
}
