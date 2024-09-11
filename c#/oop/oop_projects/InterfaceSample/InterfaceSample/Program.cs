// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using InterfaceSample;
Console.WriteLine("----------------------- Yönetici Bilgileri --------------------------");
Yonetici yonetici = new Yonetici();
yonetici.ID = 10;
yonetici.Ad = "John";
yonetici.Soyad = "Doe";
yonetici.Departman = "HR";
yonetici.Maas = 50000;
yonetici.BagliPersonelSayisi = 10;
string yoneticiInfo = yonetici.getYoneticiInfo();
Console.WriteLine(yoneticiInfo); ;


Console.WriteLine(new string('*', 100));

Calisan calisan = new Calisan();
calisan.ID = 1;
calisan.Ad = "Jeyn";
calisan.Soyad = "Doe";
calisan.Departman = "IT";
calisan.Maas = 75000;
calisan.YoneticiID = 10;
string calisanInfo = calisan.getCalisanInfo();
Console.WriteLine(calisanInfo);