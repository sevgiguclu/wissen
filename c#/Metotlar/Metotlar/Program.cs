// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Metotlar
//Bir kod parçasını, program akışı içerisinde birden fazla yerde kullanıyor isek, metot oluşturulması kod tekrarını önlemek açısından mantıklı bir seçenektir. Metot kullanımı ile daha az kod yazarak temiz bir kod yazılmış olur.

//Metotlar 2 ' ye ayrılır.

//1. Geriye değer döndürmeyen metotlar(void)
//1.1 Parametreli Metotlar
//1.2 Parametresiz Metotlar

//2 Geriye değer döndüren metotlar(int ,bool, string double... vb)
//2.1 Parametreli Metotlar
//2.2 Parametresiz Metotlar

//Geriye Değer döndürmeyen Metot -- Parametresiz

//ToplamYap1();

//Geriye Değer Döndüren Metot -- Parametresiz
//int toplam = ToplamYap2();
//Console.WriteLine($"Toplam : {toplam}");


//Geriye değer döndürmeyen Metot -- Parametre alan metot
//Kullanıcıdan alınan 3 tam sayının toplamını hesaplayıp ekrana yazan metot

//Console.Write("1. Sayıyı Giriniz : ");
//int sayi1 = int.Parse(Console.ReadLine());

//Console.Write("2. Sayıyı Giriniz : ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.Write("3. Sayıyı Giriniz : ");
//int sayi3 = int.Parse(Console.ReadLine());

//ToplamYap3(sayi1,sayi2,sayi3);

//ToplamYap3(sayi2: sayi2, sayi1:sayi1,  sayi3:sayi3);//Named Parameters Kullanımı



//Console.Write("1. Sayıyı Giriniz : ");
//int sayi1 = int.Parse(Console.ReadLine());

//Console.Write("2. Sayıyı Giriniz : ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.Write("3. Sayıyı Giriniz : ");
//int sayi3 = int.Parse(Console.ReadLine());

//int toplam = ToplamYap4(sayi1, sayi2, sayi3);
//Console.WriteLine($"Girilen 3 sayının toplamı : {toplam}");



//Geriye farklı tipte değer döndüren Metot - Parametreli

//string cevap = ToplamYap5(15.6F, 14.2F);
//Console.WriteLine(cevap);

//Varsayılan Değere Sahip(opsiyonel Parametre) Parametreli Metot
//Optinal parametre ya da optinal parametreler mutlaka parametre listesinin sonunda kullanılmaı. Gerekli parametrelerde sonra yazılmalı. 
//Optinal paramtre için varsayılan bir değer ataması yapılmalı
//Console.WriteLine("Adınızı Giriniz : ");
//string girilenAd = Console.ReadLine();
//EkranaYaz(12,girilenAd);
//EkranaYaz(10);

//Dairenin Çevresini Hesaplayan FOnksiyon
//Console.Write("Yarıçap giriniz : ");
//int yariCap = int.Parse(Console.ReadLine());
//double cevre = CevreHesapla(yariCap, Math.PI);
//Console.WriteLine(cevre);
//Console.WriteLine(CevreHesapla(yariCap));


//Belirsiz sayıda parametre alan metot tanımlamak için params keyword kullanılır. Parametrelerinin veri tiplerinin aynı olması gerekmektedir.
//params keyword ü ile birlikte kullanılan parametre mutlaka son parametre olmalı 
//Birden fazla params keywordu içeren parametre kullanılamaz
//int toplamTutar1 = FiyatlariTopla(100, 20, 50, 70, 60, 400, 300, 150, 300);
//int toplamTutar2 = FiyatlariTopla(100, 20, 50, 70, 60);
//Console.WriteLine($"Fiyat Toplamı 1 : {toplamTutar1}");
//Console.WriteLine($"Fiyat Toplamı 2  : {toplamTutar2}");

//Kullanıcıdan alınan sayının tek ya da çift olup olmadığını kontrol eden bir fonksiyon yazalım
//Console.Write("Bir sayı giriniz : ");
//int sayi = int.Parse(Console.ReadLine());
//bool sonuc = IsEven(sayi);
//if (sonuc)
//    Console.WriteLine($"{sayi} sayısı çift bir sayıdır....");
//else
//    Console.WriteLine($"{sayi} sayısı tek bir sayıdır....");


//Kullanıcıdan alına sayını asal sayı olup olmadığını söyleyen bir fonksiyon
//Console.Write("Bir sayı giriniz : ");
//int sayi = int.Parse(Console.ReadLine());
//bool sonuc = IsPrimeNumber(sayi);


#region OUT Anahtar Kelimesi

//Eğer bir metot geriye değer döndürmüyo ise(void bir metot ise) değer döndürmesi için yada bir metodun birden fazla değer döndürmesi için kullanılır.

//int sonuc, kalan;
//burada out kelimesi ile değerin adreslerini yollamış olduk
//BolmeIslemiYap(17, 5, out sonuc, out kalan);
//Console.WriteLine($"17 / 5 işleminin sonucu : {sonuc},kalanı : {kalan}");


//int bolum, kalan;
//bolum = BolmeYap(17, 5, out kalan);
//Console.WriteLine($"17 / 5 işleminin sonucu : {bolum},kalanı : {kalan}");
//int BolmeYap(int bolunen, int bolen, out int islemKalan)
//{
//    islemKalan = bolunen % bolen;
//    return bolunen / bolen; ;
//}

//void BolmeIslemiYap(int bolunen, int bolen, out int islemSonuc, out int islemKalan)
//{
////adreslerdeki değerler değişmiş oldu
//    islemSonuc = bolunen / bolen;
//    islemKalan = bolunen % bolen;
//}

#endregion

#region REF Anahtar Kelimesi
//int aDegeri = 10, bDegeri = 5;
//Console.WriteLine($"Ref ile kullanılan metodu çağırmadan önceki değerler : {aDegeri} - {bDegeri}");
//DegerleriDegistir(ref aDegeri, ref bDegeri);

//void DegerleriDegistir(ref int xDegeri, ref int yDegeri)
//{
//    int tmpValue = xDegeri;
//    xDegeri = yDegeri;
//    yDegeri = tmpValue;
//}

//Console.WriteLine($"Ref ile kullanılan metodu çağırdıktan sonraki değerler : {aDegeri} - {bDegeri}");

#endregion
bool IsPrimeNumber(int sayi)
{
    if (sayi <= 1)
        return false;

    if(sayi <= 3)
        return true;

    if (sayi % 2 == 0 || sayi % 3 == 0)
        return false;

    for (int i = 5; i * i <= sayi; i+=6)
    {
        if (sayi % i == 0 || sayi % (i + 2) == 0)
            return false;
    }

    return true;
}

bool IsEven(int sayi)
{
    bool retValue = false;
    if (sayi % 2 == 0)
        retValue = true;
    else
        retValue = false;
    return retValue;
}

int FiyatlariTopla(params int[] fiyatlar)
{
    int toplamTutar = 0;
    foreach (int fiyat in fiyatlar)
    {
        toplamTutar += fiyat;
    }
    return toplamTutar;
}

double CevreHesapla(int yariCap,double pi=3)
{
    double cevre = 2 * yariCap * pi;
    return cevre;
}

//? işareti null değer olabileceğini belirtir
//opsiyonel parametre kesinlikle en sona yazılmalı
void EkranaYaz(int yas,string? girilenAd = "John Doe",int kilo = 75)
{
    Console.WriteLine($"Merhaba : {girilenAd}");
}

string ToplamYap5(float sayi1, float sayi2)
{
    string retVal = string.Empty;
    float toplam = sayi1 + sayi2;
    retVal = $"Toplam : {toplam.ToString()}";
    return retVal;
}

int ToplamYap4(int sayi1, int sayi2, int sayi3)
{
    int retVal = sayi1 + sayi2 + sayi3;
    return retVal;
}

//fonsiyon içine yazılmış değişlkenlerin ömrü o fonksiyon bitene kadardır
void ToplamYap3(int sayi1, int sayi2, int sayi3)
{
    int toplam = sayi1 + sayi2 + sayi3;
    Console.WriteLine($"Girilen 3 sayının toplamı : {toplam}");
}

int ToplamYap2()
{
    int sayi1, sayi2;
    int toplam = 0;
    Random rnd = new Random();
    sayi1 = rnd.Next(0, 100);
    sayi2 = rnd.Next(0, 300);
    toplam = sayi1 + sayi2;
    return toplam;

    //int sayi3 = rnd.Next(100, 500);bu kod bloğu return keyword ünden sonra yazıldığı için hiç bir zaman çalıştırılmayacaktır
}

void ToplamYap1()
{
    int sayi1, sayi2;
    int toplam = 0;
    Random rnd = new Random();
    sayi1 = rnd.Next(0, 100);
    sayi2 = rnd.Next(0, 300);
    toplam = sayi1 + sayi2;
    Console.WriteLine($"Toplam : {toplam}");
}


