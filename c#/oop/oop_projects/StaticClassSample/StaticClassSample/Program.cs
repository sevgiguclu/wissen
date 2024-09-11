// See https://aka.ms/new-console-template for more information

//Math math = new Math(); //=>static olarak tanımlanmış Math ya da herhangi bir sınıf instance alınarak kullanılamaz

//double sayininUssu = Math.Pow(4, 5);
//double piDegeri = Math.P;


using StaticClassSample;

//FizikKutuphanesi fizik = new FizikKutuphanesi();//FizikKutuphanesi static olarak tanımlandığı için instance alınamaz

//FizikKutuphanesi.YerCekimiKuvveti = 9.81M;//YerCekimiKuvveti property sinin set metodu kullanılarak değer atanabilir.

//Console.WriteLine(FizikKutuphanesi.YerCekimiKuvveti);//Ekrana FizikKutuphanesi içerisindeki YerCekimi property sinin get metodunu kullarak ilgili değeri yazdırı.


//FizikKutuphanesi.SuyunKaldirmaKuvveti = 25;//Constant (sabit) değişkenlere uygulama içerisinde bir atama yapılamaz sadece constant tanımlnan yerde değeri verilerek kullanılır.

//FizikKutuphanesi.Kuvvet = 12;//readonly bir field a static constructor ve değişken initilazer dışında değer ataması yapılamaz.
//FizikKutuphanesi.SuyunKaldırmaKuvvetiniKUllan();

string str = "BUgün  ON   Üç HAZİRAN  iki BİN yirmi   Dört   perşembe";


string clearStr = str.ClearString();//oluşturduğum metodu classını yazmadan direk kullanabildim, this kullanarak,extension metod olarak isimlendirilir bu gibi metotolar

string clearStr2 = ExtensionMethod.ClearString(str);

Console.WriteLine(str);
Console.WriteLine(clearStr);
Console.WriteLine(clearStr2);

