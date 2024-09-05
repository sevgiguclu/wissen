// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region if, else , else if karar yapıları

#region Mevsim Tahmini
//SORU : Kullanıcıdan alınan ay numarasına göre hangi mevsim olduğunu ekrana yazan program

//12-1-2 için kış, 3-4-5 için ilkbahar, 6-7-8 için Yaz, 9-10-11 için Sonbahar


//Console.Write("Mevsimini öğrenmek istediğiniz ay numarasını giriniz [1 -12 arasında sayı giriniz]");

//AyNumarası:
//int ayNumarasi = int.Parse(Console.ReadLine());

//if (ayNumarasi == 12 || ayNumarasi == 1 || ayNumarasi == 2)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre KIŞ Mevsimindesiniz!!!!");
//}
//else if (ayNumarasi == 3 || ayNumarasi == 4 || ayNumarasi == 5)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre İLKBAHAR Mevsimindesiniz!!!!");
//}
//else if (ayNumarasi == 6 || ayNumarasi == 7 || ayNumarasi == 8)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre YAZ Mevsimindesiniz!!!!");
//}
//else if (ayNumarasi == 9 || ayNumarasi == 10 || ayNumarasi == 11)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre SONBAHAR Mevsimindesiniz!!!!");
//}
//else
//{
//    Console.WriteLine("Ay numarasını yanlış girdiniz. 1 ile 12 arasında sayı giriniz....");
//    goto AyNumarası;
//}





#endregion
#region İki tam sayı işlemleri
//SORU : Kullanıcıdan alınan iki tam sayıdan herhangi biri negatif ise toplamlarını, ikisi de negatif ise çarpımlarını, ikisi de pozitif ise aritmetik ortalamalarını bulup ekrana yazan program. Sayılardan biri sıfır girilir ise o sayı tekrar kullanıcıdan alınacak.

//Console.Write("1. sayıyı giriniz : ");
//sayi1Tekrar:
//int sayi1 = int.Parse(Console.ReadLine());
//if(sayi1 == 0)
//{
//    Console.Write("Sayıyı 0 girdiniz. Tekrar Giriniz : ");
//    goto sayi1Tekrar;
//}



//Console.Write("2. sayıyı giriniz : ");
//sayi2Tekrar:
//int sayi2 = int.Parse(Console.ReadLine());
//if (sayi2 == 0)
//{
//    Console.Write("Sayıyı 0 girdiniz. Tekrar Giriniz : ");
//    goto sayi2Tekrar;
//}

//if(sayi1 < 0 && sayi2 < 0) {
//    Console.WriteLine($"Sayıların ikisi de negatif girildiği için çarpımları : {sayi1 * sayi2}");
//}
//else if(sayi1 < 0 || sayi2 < 0)
//{
//    Console.WriteLine($"Sayıların bir tanesi negatif girildiği için toplamları : {sayi1 + sayi2}");
//}
//else if(sayi1 > 0 && sayi2 > 0)
//    Console.WriteLine($"Sayıların ikisi de pozitif girildiği için aritmetik ortalama : {(sayi1 + sayi2) / 2}");

#endregion
#region İçeçecek Tercihi

//SORU : Kullanıcıdan alınan tercih bilgisine göre hangi içeceği tercih edildiğini ekrana yazan program.
//(C : çay, L : Limonata, G : Gazozo, K : Kola)

//yenidenTercih:
//Console.Write("Hangi içeiceği tercih edersini ? [C : çay, L : Limonata, G : Gazozo, K : Kola]");
//string icecekTercihi = Console.ReadLine();

//if (icecekTercihi == "C" || icecekTercihi == "c")
//    Console.WriteLine("İçecek Tercihiniz ÇAY oldu");
//else if (icecekTercihi == "L" || icecekTercihi == "l")
//    Console.WriteLine("İçecek Tercihiniz LİMONATA oldu");
//else if (icecekTercihi == "G" || icecekTercihi == "g")
//    Console.WriteLine("İçecek Tercihiniz GAZOZ oldu");
//else if (icecekTercihi == "K" || icecekTercihi == "k")
//    Console.WriteLine("İçecek Tercihiniz KOLA oldu");
//else
//{
//    Console.WriteLine("Yanlış içecek tercihi yaptınız. Lütfen tekrar deneyiniz...");
//    goto yenidenTercih;
//}
#endregion
#endregion

#region Switch.... Case
//switchlerde mantıksal operatörler kullanılmaz 
#region İçecek Tercihi
//SORU : Kullanıcıdan alınan tercih bilgisine göre hangi içeceği tercih edildiğini ekrana yazan program.
//(C : çay, L : Limonata, G : Gazozo, K : Kola)

//yenidenTercih:
//Console.Write("Hangi içeiceği tercih edersini ? [C : çay, L : Limonata, G : Gazozo, K : Kola]");
//string icecekTercihi = Console.ReadLine();

//switch(icecekTercihi)
//{
//    case "C":
//    case "c":
//        Console.WriteLine("İçecek Tercihiniz ÇAY oldu");
//        break;
//    case "L":
//    case "l":
//        Console.WriteLine("İçecek Tercihiniz LİMONATA oldu");
//        break;
//    case "G":
//    case "g":
//        Console.WriteLine("İçecek Tercihiniz GAZOZ oldu");
//        break;
//    case "K":
//    case "k":
//        Console.WriteLine("İçecek Tercihiniz KOLA oldu");
//        break;
//    default:
//        Console.WriteLine("Yanlış içecek tercihi yaptınız. Lütfen tekrar deneyiniz...");
//        goto yenidenTercih;
//}
#endregion

#region Mevsim Tercihi
//SORU : Kullanıcıdan alınan ay numarasına göre hangi mevsim olduğunu ekrana yazan program

//12-1-2 için kış, 3-4-5 için ilkbahar, 6-7-8 için Yaz, 9-10-11 için Sonbahar

Console.Write("Mevsimini öğrenmek istediğiniz ay numarasını giriniz [1 -12 arasında sayı giriniz]");

AyNumarası:
int ayNumarasi = int.Parse(Console.ReadLine());

switch(ayNumarasi)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre KIŞ Mevsimindesiniz!!!!");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre İLKBAHAR Mevsimindesiniz!!!!");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre YAZ Mevsimindesiniz!!!!");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine($"Girdiğiniz ay numarasına {ayNumarasi} göre SONBAHAR Mevsimindesiniz!!!!");
        break;
    default:
        Console.WriteLine("Ay numarasını yanlış girdiniz. 1 ile 12 arasında sayı giriniz....");
        goto AyNumarası;
}
#endregion

#endregion
