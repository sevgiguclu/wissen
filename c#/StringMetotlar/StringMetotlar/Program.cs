// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region String Metotlar
//012345678910
//Length
//string metin = "Hello World!!!";
//int uzunlukMetin = metin.Length;
//Console.WriteLine(uzunlukMetin);

//IndexOf ve LastIndexOf
//string metin = "Hello World!!!";
//int firstIndex = metin.IndexOf('l');
//int lastIndex = metin.LastIndexOf('l');

//Contains
//string metin = "BUgün 30 Mayıs 2024 Perşembe";
////bool varMi = metin.Contains("mayıs");
//bool varMi = metin.Contains("mayıs",StringComparison.OrdinalIgnoreCase);
//ikinci parametre büyük küçük harf duyarlılığını kapatır
//Console.WriteLine(varMi);


//EndsWith , StartsWith
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//bool bitiyorMu = metin.EndsWith("be");
//bool basliyorMu = metin.StartsWith("Bugün");
//Console.WriteLine(bitiyorMu);
//Console.WriteLine(basliyorMu);

//ToLower, ToUpper
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//string hepsiKucuk = metin.ToLower();
//string hepsiBuyuk = metin.ToUpper();
//Console.WriteLine(hepsiKucuk);
//Console.WriteLine(hepsiBuyuk);

//Insert, Remove
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
////metin = metin.Insert(metin.Length, " Saat 14:00");
//string eklenmisMetin = metin.Insert(metin.Length," Saat 14:00");
//Console.WriteLine(eklenmisMetin);
//string silinmisMetin = eklenmisMetin.Remove(metin.Length,6);
//Console.WriteLine(silinmisMetin);

//Replace
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//string degistirilenMetin = metin.Replace("Mayıs", "Haziran");
//Console.WriteLine(degistirilenMetin);

//Reverse
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
////string degistirilenMetin = metin.Reverse().ToArray();
//Console.WriteLine(metin.Reverse().ToArray());

//SubString
//string metin = "Bugün 30 Mayıs 2024 Perşembe";
//string altMetin = metin.Substring(20, 15);
//string altMetin = metin.Substring(metin.Length, 5);
//Console.WriteLine(altMetin);
//Console.WriteLine(altMetin.Length);
//Console.WriteLine(altMetin.Trim());
//Console.WriteLine(altMetin.Trim().Length);
#endregion

#region Ödev
#region 1
//SORU : Kullanıcıdan alınan metini kelimelere bölerek alt alta kelimeri yazan program
//metinBolme:
//Console.WriteLine("Lütfen bir metin giriniz");
//string metin = Console.ReadLine().Trim();
//string alt_metin;
//if (metin.Length > 0)
//{
//    int bosluk_index = metin.IndexOf(" ");
//    while(bosluk_index != -1)
//    {
//        alt_metin = metin.Substring(0, bosluk_index);
//        Console.WriteLine(alt_metin);
//        metin = metin.Remove(0, bosluk_index).Trim();
//        bosluk_index = metin.IndexOf(" ");
//    }
//    Console.WriteLine(metin);
//    goto metinBolme;

//}
//else
//{
//    Console.WriteLine("Lütfen bir metin giriniz");
//    goto metinBolme;
//}

#endregion

#region 2
//SORU : "10 25 10 35 80 10 65 80 10 82 10 90 40 50 10" Bu string içerisinde kaç adet 10 ifadesi bulunmaktadır
//string sayilar = "10 25 10 35 80 10 65 80 10 82 10 90 40 50 10";
//int bosluk_index = sayilar.IndexOf(" ");
//int sayac = 0;
//while(bosluk_index != -1)
//{
//    string altküme = sayilar.Substring(0, bosluk_index);
//    if (altküme == "10")
//        sayac++;

//    sayilar = sayilar.Remove(0, bosluk_index+1) ;
//    bosluk_index = sayilar.IndexOf(" ");

//}
//if (sayilar == "10")
//    sayac++;
//Console.WriteLine("Bu stringde tam " + sayac + " adet 10 değeri vardır..");


#endregion

#endregion

#region DateTime Metotlar
//DatetTime metotları, bir tarih ve ya zaman bilgisi ile çalışmak için kullanılır

//Günün tarihi ve zamanını alan property(özellik) ler
//DateTime gununTarihi = DateTime.Today; tarih verir saati 0 olarak gösterir
//DateTime gununZamani = DateTime.Now; // tarih ve saat verir
//DateTime gununZamaniUTC = DateTime.UtcNow; //dünya merkez (0) noktasının tarih ve saatini alır 
//Console.WriteLine(gununTarihi);
//Console.WriteLine(gununZamani);
//Console.WriteLine(gununZamaniUTC);

//Zaman Dilimi Ekleme Fonksiyonları

//DateTime zaman = DateTime.Now;
//DateTime eklenmisSaat = zaman.AddHours(5);
//DateTime eklenmisGun = zaman.AddDays(6);
//DateTime eklenmisYıl = zaman.AddYears(6);

//Console.WriteLine(eklenmisSaat);
//Console.WriteLine(eklenmisGun);
//Console.WriteLine(eklenmisYıl);

//Zaman parçalarını alabilmek için kullanılan property(özellik) ler
//DateTime zaman = DateTime.Now;
//Console.WriteLine($"Zaman : {zaman}");
//Console.WriteLine($"Yıl : {zaman.Year}");
//Console.WriteLine($"Ay : {zaman.Month}");
//Console.WriteLine($"Gün : {zaman.Day}");
//Console.WriteLine($"Saat : {zaman.Hour}");
//Console.WriteLine($"Dakika : {zaman.Minute}");
//Console.WriteLine($"Saniye : {zaman.Second}");
//Console.WriteLine($"Milisaniye : {zaman.Millisecond}");
//Console.WriteLine($"Haftanın Günü : {zaman.DayOfWeek}");

//Kısa ve Uzun Tarih Formatı ile Kısa ve Uzun Zaman FOrmatı

//DateTime zaman = DateTime.Now;
//Console.WriteLine($"Kısa Tarih Formatı : {zaman.ToShortDateString()}");
//Console.WriteLine($"Uzun Tarih Formatı : {zaman.ToLongDateString()}");
//Console.WriteLine($"Kısa Zaman Formatı : {zaman.ToShortTimeString()}");
//Console.WriteLine($"Uzun Zaman Formatı : {zaman.ToLongTimeString()}");

//Custom Zaman Format Kullanımı


//DateTime zaman = DateTime.Now.AddHours(2);
//Console.WriteLine(zaman.ToString("yyyy-MM-dd"));
//Console.WriteLine(zaman.ToString("yyyy-MM-dd HH:mm:ss"));
//Console.WriteLine(zaman.ToString("yyyy-MM-dd hh:mm:ss"));
//Console.WriteLine(zaman.ToString("yyyy-MMM-dd HH:mm:ss"));
//Console.WriteLine(zaman.ToString("yyyy-MM-ddd HH:mm:ss"));
//Console.WriteLine(zaman.ToString("yyy-MM-dd HH:mm:ss"));
//Console.WriteLine(zaman.ToString("yy-MM-dd HH:mm:ss"));
//Console.WriteLine(zaman.Subtract(DateTime.Now));
//Console.WriteLine(zaman - (DateTime.Now));
#endregion

#region Matematik Metotları
//Matematiksel metotların bulunduğu Math kütüphanesi içerisinden gerekli metotları kullanarak matematikse işlemlerimizi gerçekleştirebiliriz.

//Mutlak Değer Alma
////int mutlakDeger = 0;
//int sayi = -123;
//int mutlakDeger = Math.Abs(sayi);
//Console.WriteLine(mutlakDeger);

//Matematik kurallarına göre yuvarlama işlemi
//double sayi = 28.6//yuvarlayınca 29
//double sayi = 14.5// kullanılan methoda göre değişir

//double sayi = 14.5234;
//double yuvarlananSayiRound = Math.Round(sayi); //14 ( buçujlu değerlerde en yakın çift sayıya yuvarlar)
//double yuvarlananSayiFlour = Math.Floor(sayi);//alt sayıya yuvarlar
//double yuvarlananSayiCeiling = Math.Ceiling(sayi);//üst sayıya yuvarlar
//Console.WriteLine(yuvarlananSayiRound);
//Console.WriteLine(yuvarlananSayiFlour);
//Console.WriteLine(yuvarlananSayiCeiling);

//Console.WriteLine(Math.PI);

//double sayi = 625;
//double karekok = Math.Sqrt(sayi);//karakökünü alır
//Console.WriteLine(karekok);
//double sayi = 7;
//double ustAlinanSayi = Math.Pow(sayi, 4);// 7 üzeri 4 sonucunu verir
//Console.WriteLine(ustAlinanSayi);

//int sayi1 = 25, sayi2 = 30;
//Console.WriteLine(Math.Min(sayi1,sayi2));
//Console.WriteLine(Math.Max(sayi1, sayi2));
#endregion
//Console.ReadLine();