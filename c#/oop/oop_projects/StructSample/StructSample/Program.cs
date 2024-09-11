namespace StructSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //myStruct myStruct = new myStruct();
            //Console.WriteLine($"{myStruct.x} - {myStruct.y} - {myStruct.z}");//initial değerleri yazdı, 0 false ve boş
            ////new keywordü çalıştığında initial değerler atanır, new keywordü ile tanımlamazsak initial değrleri kendimiz vermemiz gerekir

            //myStruct myStruct1;
            //myStruct1.x = 2;
            //myStruct1.y = true;
            //myStruct1.z = "Sevgi";
            //Console.WriteLine($"{myStruct1.x} - {myStruct1.y} - {myStruct1.z}");


            //myStruct myStruct = new myStruct();
            //myStruct.x = 5;
            //myStruct.y = true;
            //myStruct.z = "2";
            //Console.WriteLine($"{myStruct.x} - {myStruct.y} - {myStruct.z}");
            //Console.WriteLine(myStruct.Islem());

            //Console.WriteLine(myStruct.Isim());



            //myStruct myStruct = new myStruct();
            //myStruct.MyClass myclass = new myStruct.MyClass();//struct içindeki classı bu şekilde instance edebilrim
            //myclass.a = 1;
            //myclass.b = DateTime.Now.AddDays(5);
            //Console.WriteLine($"{myclass.a} - {myclass.b.ToLongDateString()}");

            //MyClass2 myClass2 = new MyClass2();
            //myClass2.myS    //olmuyor hata veriyor

            //MyClass2.MyStruct myStruct = new MyClass2.MyStruct();
            //myStruct.x = 2;
            //myStruct.z = "10";
            //Console.WriteLine(myStruct.Islem());



            ///structlar değer tiplidir ve steakde çalışır, classlar referans tiplidir ve heapde çalışır
            ///*structlar değer tipli olduğu için , classlarda referans tipli olduğu için ,
            // * structlarda = yapıldığında ilk öğenin değeri aynı kalırken ,
            // * classlarda = durumunda ilk öğenin de değeleri yeni öğenin değiştirilmiş değerine eşit olur
            //*/
            //myStruct my_struct = new myStruct();
            //my_struct.x = 5;
            //my_struct.a = 2;

            //myStruct my_struct2 = my_struct;
            //my_struct2.x = 55;
            //my_struct2.a = 22;

            //Console.WriteLine("struct ile oluşturduğumuz yapıda ilk tanımlanan öğenin");
            //Console.WriteLine("x değeri : " + my_struct.x);
            //Console.WriteLine("a değeri : " + my_struct.a);
            //Console.WriteLine("struct ile oluşturduğumuz yapıda ilk öğeye eşitlenen ikinci öğenin");
            //Console.WriteLine("x değeri " + my_struct2.x);
            //Console.WriteLine("a değeri " + my_struct2.a);

            //Console.WriteLine(new string('*', 100));

            //MyClass2 my_class2 = new MyClass2();
            //my_class2.a = 5;
            //my_class2.b = 2;

            //MyClass2 myClass2 = my_class2;
            //myClass2.a = 55;
            //my_class2.b = 22;
            //Console.WriteLine("class ile oluşturduğumuz yapıda ilk tanımlanan öğenin");
            //Console.WriteLine("x değeri : " + my_class2.a);
            //Console.WriteLine("a değeri : " +  my_class2.b);
            //Console.WriteLine("class ile oluşturduğumuz yapıda ilk öğeye eşitlenen ikinci öğenin");
            //Console.WriteLine("x değeri " + myClass2.a);
            //Console.WriteLine("a değeri " + myClass2.b);


            //Kitap k = new Kitap();
            //Console.WriteLine(k.ToString());

            //Kitap k = new Kitap(1, "Suç ve Ceza", "Roman");
            //Console.WriteLine(k.ToString());

            Kitap k = new Kitap(1, "Müptezeller", "Roman", "5464656", "Emrah Serbes");
            Console.WriteLine(k.ToString());

        }


    }

    #region giriş

    ////structlar başka bir struct ya da classdan miras alamaz 
    //// interfaceden türeyebilir
    //struct struct1 /*:Struct2*/
    //{
    //    int x;
    //    int y;
    //}

    //struct Struct2 /*:Class1*/
    //{
    //    int a;
    //    int b;
    //}

    //struct Struct3 : IInterface
    //{
    //    public void A()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void B(bool c)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Class1
    //{
    //    int z;
    //    bool w;
    //}

    //interface IInterface
    //{
    //    void A();
    //    void B(bool c);
    //}

    #endregion

    #region örnekler
    struct myStruct
    {
        //struct yapısının içerisinde property field ya da static ya da normal birmetot oluşturabilrim 
        public int x;
        public int a;
        public bool y;
        public string z;//public string z {get;set} şeklinde de yazılabilirdi, o zaaman field değil properrty olurdu

        public double Islem()
        {
            if (y)
            {
                return x * int.Parse(z);
            }
            return -1;
        }

        public static string Isim()
        {
            return "BERKAY FOTA";
        }

        //structın içinde sınıf da tanımlayabilirim
        public class MyClass
        {
            public int a { get; set; }
            public DateTime b { get; set; }
        }

    }

    //bir classın içinde de struct oluşturabilirim
    class MyClass2
    {
        public int a { get; set; }
        public int b;
        public struct MyStruct
        {
            public int x;
            public string z { get; set; }

            public int Islem()
            {
                return x * int.Parse(z);
            }
        }

    }

    public struct Kitap
    {

        public Kitap()
        {
            KitapID = 1;
            KitapAdi = "Nutuk";
            KitapTuru = "Roman";
            ISBN = "56446464646";
            YazarAdi = "MKA";
        }
        public Kitap(int kitapID, string kitapAdi, string kitapTuru)
        {
            KitapID = kitapID;
            KitapAdi = kitapAdi;
            KitapTuru = kitapTuru;
            /* Constructor içinde property lere değerler atanmalıdır. 
             * property e bir değer atanmaz ise property nin veri tipinin başlangıç değerini alır. 
            */
        }

        public Kitap(int kitapID, string kitapAdi, string kitapTuru, string isbn, string yazarAdi)
        {
            KitapID = kitapID;
            KitapAdi = kitapAdi;
            KitapTuru = kitapTuru;
            ISBN = isbn;
            YazarAdi = yazarAdi;
        }

        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public string ISBN { get; set; }
        public string YazarAdi { get; set; }

        public override string ToString()
        {
            return $"Kitap ID : {KitapID}\n" +
                $"Kİtap Adı : {KitapAdi}\n" +
                $"Kitap Türü : {KitapTuru}\n" +
                $"ISBN : {ISBN}\n" +
                $"Yazar Adı : {YazarAdi}";
        }
    }

    #endregion



}
