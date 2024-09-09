// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Diziler : Aynı tipdeki verileri bir arada tutmamızı sağlayan nesnelerdir.

//Dizi Tanımlama
//VeriTipi[] diziDeğişkenAdi = {Değer1, Değer2,Değer3,Değer4,Değer5.....} Eleman sayısını belirlemeden dizi tanımlama
//VeriTipi[] diziDeğişkenAdi = new VeriTipi[ElemanSayis] Eleman sayısı baştan belli olacak şekilde dizi tanımlama

//string[] dizi = new string[3] { "John Doe", "Jeyn Doe", "Tom Doe", "Poul Doe" };

//string[] names = { "John Doe", "Jeyn Doe", "Tom Doe", "Poul Doe" };

//Console.WriteLine(names.Length);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[5]);//olamyan index , hata verir

//string[] names = new string[6];
//names[0] = "John Doe";
//names[1] = "Jeyn Doe";
//names[2] = "Tom Doe";
//names[3] = "Bill Doe";
//names[4] = "Poul Doe";
//names[5] = "Serahhn Doe";

//for (int i = 0; i < names.Length; i++)
//for (int i = 0; i <= names.Length - 1; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//string[] metinDizisi = metin.Split(' ');
//foreach (string met in metinDizisi)
//{
//    Console.WriteLine(met);
//}

//Dizi Metotları
//int[] sayilar = { 10, 20, 5, 85, 32, 15, 23 };
//foreach (int sayi in sayilar)
//{   
//    Console.WriteLine("sırasız : " + sayi);
//}

//Array.Sort(sayilar);
//foreach (int sayi in sayilar)
//{
//    Console.WriteLine("sıralı : " + sayi);
//}
//Array.Reverse(sayilar);
//foreach (int sayi in sayilar)
//{
//    Console.WriteLine("ters : " +  sayi);
//}


#region ödev

//SORU : Kullanıcının gireceği adet kadar tam sayıları alıp bir dizi oluşturulduktan sonra dizi elemanları küçükten büyüğe ve büyükten küçüğe sıralamasını yapan program. sort ve reserve kullanma , sıralama algoritmaları var 

//Console.WriteLine("kaç tane sayı gireceğinizi belirtiniz");
//int adet, sayi;
//bool sonuc = int.TryParse(Console.ReadLine(), out adet);

//if (sonuc)
//{
//    int[] dizi = new int[adet];

//    //diziyi oluşturma
//    for(int i = 0; i < dizi.Length; i++)
//    {
//        Console.WriteLine("sayı giriniz");
//        bool bSayi = int.TryParse(Console.ReadLine(),out sayi);
//        while (!bSayi)
//        {
//            Console.WriteLine("Lütfen tam sayı giriniz");
//            bSayi = int.TryParse(Console.ReadLine(), out sayi);
//        }

//        dizi[i] = sayi;
//        Console.WriteLine("eleman : " + sayi);

//    }

//    //sıralama büyükten küçüğe
//    for (int k = 0; k < dizi.Length-1; k++)
//    {
//        for(int j =0; j < dizi.Length - 1; j++)
//        {
//            if (dizi[j] > dizi[j+1])
//            {
//                int temp = dizi[j];
//                dizi[j] = dizi[j + 1];
//                dizi[j + 1] = temp;
//            }
//        }
//    }

//    Console.WriteLine("dizinin en küçük elemanı : " + dizi[0]);
//    Console.WriteLine("dizinin en büyük elemanı : " + dizi[dizi.Length - 1]);



//    //sıralama küçükten büyüğe
//    for (int k = 0; k < dizi.Length - 1; k++)
//    {
//        for (int j = 0; j < dizi.Length - 1; j++)
//        {
//            if (dizi[j] < dizi[j + 1])
//            {
//                int temp = dizi[j];
//                dizi[j] = dizi[j + 1];
//                dizi[j + 1] = temp;
//            }
//        }
//    }
//    Console.WriteLine("dizinin en küçük elemanı : " + dizi[dizi.Length - 1]);
//    Console.WriteLine("dizinin en büyük elemanı : " + dizi[0]);





//}

#endregion


#region Dizi Metotoları devam (string dizileri)

string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Bursa", "Samsun" };
//Array.Sort(sehirler);
//foreach (var sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

//Array.Reverse(sehirler);
//Console.WriteLine(new string('*', 100));
//Console.WriteLine("tersten sıralama : ");

//foreach (var sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}


//dizinin boyutunu değiştirme
//Array.Resize(ref sehirler, 4);
//foreach (var sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

//Array.Resize(ref sehirler, sehirler.Length+1);
//sehirler[sehirler.Length - 1] = "Çanakkale";
//foreach (var sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

//indexOf lastIndexOf
//string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Ankara", "Eskişehir", "Bursa", "Samsun", "Ankara" };

//bir tane varsa indexOf ve lastIndexof aynı değerde olur
//int ilkIndex = Array.IndexOf(sehirler, "Ankara");
//Console.WriteLine("İlk index : " + ilkIndex);
//int sonIndex = Array.LastIndexOf(sehirler, "Ankara");
//Console.WriteLine("son index  : " + sonIndex);

//Array.Clear(sehirler);
//sehirler.clone bir obje döndürür ,eşitlik sağlamak için burda (string[]) kullanıyoruz
string[] yeni_sehirler = (string[]) sehirler.Clone();//boxing işlemi

//string olan bişeyi objeye döndürseydik o da unboxing olacaktı

foreach (var item in yeni_sehirler)
{
    Console.WriteLine(item);
}
#endregion

#region ödev
//hangi dizi elemanı kaç adet tekrar etmiş yaz ve dizi elamanlarının her biri bi kere olacak şekilde diziyi değştiren program
//string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Bursa", "İzmir","Erzurum", "Ankara","Çanakkale", "İstanbul", "Bursa", "Bilecik",
//    "İstanbul","Bursa","Ankara","Kars","İstanbul" };

//string[] yeni_sehirler = { };
//foreach (string s in sehirler)
//{
//    int var_olan_Sehir = Array.IndexOf(yeni_sehirler, s);
//    if (var_olan_Sehir == -1)
//    {
//        Array.Resize(ref yeni_sehirler, yeni_sehirler.Length + 1);
//        yeni_sehirler[yeni_sehirler.Length - 1] = s;

//        int sayac = 0;
//        for (int i = 0; i < sehirler.Length; i++)
//        {
//            if (s == sehirler[i])
//            {
//                sayac++;
//            }
//        }

//        Console.WriteLine($"{s} değerinden bu dizide tam {sayac} tane var..");
//    }

//}

//Console.WriteLine("\n*******Değiştirilmiş dizi : ");
//foreach (var item in yeni_sehirler)
//{
//    Console.WriteLine(item);
//}

#endregion