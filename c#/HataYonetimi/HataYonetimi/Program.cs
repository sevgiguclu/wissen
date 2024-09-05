// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Derleme Hataları
//Console.WriteLine("Hello World!!!!")//Satırın sonunda mutlaka ";" noktalı virgül olmalıdır. Olmadığı durumda syntax hatası ortaya çıkar

//string deger = 13;//==> Atama işlemlerinde eşitliğin sağındaki değer ile solundaki veri tipi uyumlu olmalıdır. Olmadığı zaman derleme zamanı hataları meydana gelir.


//Runtime (Çalışma zamanı) hataları
//Kullanıcıdan telefon numarasını alıp eğer doğru formatta ise doğru girdiniz yanlış formatta ise yanlış diye mesaj verileri
//DOğru Forma : 10 haneli başında 0 olmadan yazılmalı
//5551112233

//tekrarGiris:
//Console.Write("Telefon NUmaranızı 10 hane ve başında 0 olmadan giriniz : ");
//string telefon = Console.ReadLine();
//if(telefon.Length == 10)
//{
//Console.WriteLine("Telefon numarası uzunluğu 10 karakterdir...");
//////long telefonLong = long.Parse(telefon);
////int telefonInt = int.Parse(telefon);
////Console.WriteLine($"Girilen Telefon NUmarası : {telefonInt}");
//////Console.WriteLine($"Girilen Telefon NUmarası : {telefonLong}");
/////

//int telefonInt;
//bool sonuc = int.TryParse(telefon, out telefonInt);
//if(sonuc)
//{
//    Console.WriteLine("Doğru bir telefon numarası girdiniz...");
//}
//else
//{
//    Console.WriteLine("İstenilen formatta giriş yapmadınız. Tekrar giriniz");
//    goto tekrarGiris;
//}

#region Try Catch Kullanımı
//try
//{
//    Console.Write("Telefon Numaranızı 10 hane ve başında 0 olmadan giriniz : ");
//    string telefon = Console.ReadLine();
//    int telefonINt = int.Parse(telefon);
//    Console.WriteLine($"Tebrikler doğru formatta telefon numarası girdiniz : {telefonINt}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Telefon numarasını düzgün giriniz : " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Hata alsa da almasa da çalışacak olan bölüm");
//}


#endregion

#region Exception Sınıfları Genel Bakış
try
{
	Console.Write("1. sayıyı giriniz : ");
	int sayi1 = int.Parse(Console.ReadLine());
	Console.Write("2. sayıyı giriniz : ");
	int sayi2 = int.Parse(Console.ReadLine());
	double sonuc = sayi1 / sayi2;

	Console.WriteLine("Sonuç : " + sonuc);
}
catch(DivideByZeroException divedeZeroEx)
{
	Console.WriteLine(divedeZeroEx.Message);
    Console.WriteLine(divedeZeroEx.Source);
    Console.WriteLine(divedeZeroEx.HelpLink);
    Console.WriteLine(divedeZeroEx.InnerException);
    Console.WriteLine(divedeZeroEx.StackTrace);
    Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz..");
}
catch(OverflowException overFlowEx)
{
    Console.WriteLine(overFlowEx.Message);
    Console.WriteLine(overFlowEx.Source);
    Console.WriteLine(overFlowEx.HelpLink);
    Console.WriteLine(overFlowEx.InnerException);
    Console.WriteLine(overFlowEx.StackTrace);
    Console.WriteLine("Integer değer büyük sayı girdiniz");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
