// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region For Döngüsü
//SORU : 1 den 10 kadar (10 dahil) tam sayıları alt alta yazan program

//for(baslangic;koşul;artım(iterasyon))
//{
//    Çalışcak KOdlar
//}


//for (int i = 1; i <=10; i++)
//{
//    Console.WriteLine(i.ToString());
//}

//for (int i = 1; i <= 10; i+=2)
//{
//    Console.WriteLine(i.ToString());
//}

//for (int i = 10; i >=1 ; i--)
//{
//    Console.WriteLine(i.ToString());
//}


////SORU : 1 ile 50 arasındaki(50 dahil) çift tam sayıların toplamını bulan ve ekrana yazan program
//int toplam=0;
////for (int i = 2; i  <=50; i+=2)
////{
////    //toplam = toplam + i;
////    toplam += i;
////}

//for (int i = 1; i <= 50; i++)
//{
//    if (i % 2 == 0)
//        toplam += i;
//}
//Console.WriteLine(toplam);

//SORU : Kullanıcıdan alınan 10 adet tam sayıdan en büyüğünü ve en küçüğünü bulup ekrana yazan program

//int sayi, enBuyuk, enKucuk;
//enBuyuk = enKucuk = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Lütfen {(i + 1)} . sayıyı giriniz");
//    sayi = int.Parse(Console.ReadLine());

//    if (i == 0)
//        enBuyuk = enKucuk = sayi;

//    if (sayi < enKucuk)
//        enKucuk = sayi;

//    if (sayi > enBuyuk)
//        enBuyuk = sayi;
//}

//Console.WriteLine(enKucuk);
//Console.WriteLine(enBuyuk);
#endregion



#region While Döngüsü
//SORU : 1 ile 100 arasındaki sayıları(100 dahil) alt alta yazan program
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

//int sayac = 1;
//while (sayac <= 100)
//{
//    Console.WriteLine(sayac);
//    sayac++;
//}

//SORU : Kullanıcıdan alınan metni, yine kullanıcının girdiği tekrar sayısı kar alt alta yazan program.
//Console.WriteLine("Tekrar etmesini istediğiniz metni giriniz : ");
//string metin = Console.ReadLine();

//Console.WriteLine("Metni kaç defa tekrar yazdırmak istediğiniz belirtiniz : ");
//bool sonuc = int.TryParse(Console.ReadLine(), out int tekrarSayisi);
//if(sonuc)
//{
//    int sayac = 1;
//    while(sayac <= tekrarSayisi)
//    {
//        Console.WriteLine(metin);
//        sayac++;
//    }
//}
//else
//{
//    Console.WriteLine("Tekrar sayısını hatalı girdiniz...");
//}
#endregion

#region Do ... While Döngüsü

////SORU : Kullanıcıdan alınan sayının faktoriyelini hesaplayıp ekrana yazan program
//decimal faktoriyel = 1, girilenSayi;

//Console.Write("Faktoriyel hesaplamak istediğiniz sayıyı giriniz : ");

//bool sonuc = decimal.TryParse(Console.ReadLine(), out girilenSayi);

//if(sonuc)
//{
//    if (girilenSayi == 0)
//        Console.WriteLine("Girilen sayı 0 olduğu için faktoriye 1");
//    else if (girilenSayi > 0)
//    {
//        do
//        {
//            faktoriyel *= girilenSayi;
//            girilenSayi--;
//        } while (girilenSayi >= 1);
//        Console.WriteLine(faktoriyel);
//    }
//    else
//        Console.WriteLine("Negatif sayıların faktoriyel değeri hesaplanmaz...");
//}
//else
//{
//    Console.WriteLine("Sayısal bir değer girmediniz...");
//}

#endregion

#region ödev
// suyun derecesine göre hangi halde olduğunu bulan kod(hem if hem de switch case ile)

#region if ile

//suHali:
//Console.WriteLine("Lütfen suyun derecesini giriniz.");

////int suDerece = int.Parse(Console.ReadLine());
//bool sonuc = int.TryParse(Console.ReadLine(), out int suDerece);

//if (sonuc)
//{
//    if (suDerece <= 0)
//    {
//        Console.WriteLine($"Belirtiğiniz {suDerece} değerine göre su katı haldedir..");
//    }
//    else if (suDerece >= 100)
//    {
//        Console.WriteLine($"Belirttğiniz {suDerece} değerine göre su gaz haldedir..");
//    }
//    else if (0 < suDerece && suDerece < 100)
//    {
//        Console.WriteLine($"Belirttğiniz {suDerece} değerine göre su sıvı haldedir..");
//    }
//    goto suHali;
//}
//else
//{
//    Console.WriteLine("Lütfen geçerli bir değer giriniz..");
//    goto suHali;
//}


#endregion

#region switch ile 

//suyunHali:
//Console.WriteLine("Lütfen suyun derecesini giriniz.");
//bool deger = int.TryParse(Console.ReadLine(), out int derece);

//switch (deger)
//{
//    case true:
//        switch (derece)
//        {
//            case (<= 0):
//                Console.WriteLine($"Belirtiğiniz {derece} değerine göre su katı haldedir..");
//                goto suyunHali;
//            case (< 100):
//                Console.WriteLine($"Belirtiğiniz {derece} değerine göre su sıvı haldedir..");
//                goto suyunHali;
//            default:
//                Console.WriteLine($"Belirtiğiniz {derece} değerine göre su gaz haldedir..");
//                goto suyunHali;
//        }
//    case false:
//        Console.WriteLine("Lütfen geçerli bir değer giriniz..");
//        goto suyunHali;
//}


#endregion




#endregion

#region continue ve break
Console.Write("bir tam sayı giriniz");
bool sonuc = int.TryParse(Console.ReadLine(), out int sayi);
int toplam = 0;
if (sonuc)
{
    for (int i = 1; i <= sayi; i++)
    {
        if (sayi % 2 == 0)
            continue;
        toplam += i;

        if (toplam > 300)
            break;
    }

    Console.WriteLine("sonuc : " + toplam);
}

else
    Console.WriteLine("yanlış değer girdiniz..");

#endregion