// See https://aka.ms/new-console-template for more information

//using InheritanceSample;

//Tasit tasit = new Tasit();
using InheritanceSample;

Araba araba = new Araba();//instance yapıldı
//int tekerSayisi = araba. //teker sayısına burda ulaşamıyorum çünkü protected, sadece miras aldığım yerde ulaşabilirim araba sınıfında 
Console.WriteLine("****************************");
Araba araba2 = new Araba(10, 5);