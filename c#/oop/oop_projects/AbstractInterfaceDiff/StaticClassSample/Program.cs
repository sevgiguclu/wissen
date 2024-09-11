// See https://aka.ms/new-console-template for more information

using StaticClassSample;

//double toplam =  Matematik.Toplam(3, 5);
//Console.WriteLine(toplam);

//Matematik toplamlar = new Matematik();
//double sonuc = toplamlar.Toplamlar(10, 2, 3);
//Console.WriteLine(sonuc);

//Matematik mt1 = new Matematik();
//Matematik mt2 = new Matematik();
//Matematik mt3 = new Matematik();

//Console.WriteLine(Matematik.Pi);
//Console.WriteLine(Matematik.Pi);
//Console.WriteLine(Matematik.Pi);

Matematik mt1 = new Matematik();
Matematik mt2 = new Matematik();
Console.WriteLine(Matematik.Pi);//constructor yazmadan önce : 3,14
Console.WriteLine(Matematik.Pi);//constructor yazmadan önce : 3,14
mt1.PiDegistir(3);
Matematik mt3 = new Matematik();
Matematik mt4 = new Matematik();
Console.WriteLine(Matematik.Pi);//static olmayan construcutr çalışmadığı sürece 3
Console.WriteLine(Matematik.Pi);//static olmayan construcutr çalışmadığı sürece 3



