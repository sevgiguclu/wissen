// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ClassInstanceSample;

//Animal animal = new Animal();
//Animal animal1 = new Animal("sürüngen");

//eskiden kendimiz get ve setter yapıyorduk ama artık hazırı ve kısası var
//getter ve setter ile encapsulatin yapmış oluyoruz. field ile kapalı olan diğer nesnelerle iletişimini açıyoruz get ve set ile property ile 
//animal.setAnimalType("sürüngen");
//Console.WriteLine(animal.getAnimalType());

//animal.AnimalType = "Sürüngen";
//Console.WriteLine(animal.AnimalType);

//animal.Speed = 50;
//Console.WriteLine(animal.Speed);

//garbage collection çalışınca yıkıcı metod çalışacaktır
//for (int i = 0; i < 100000; i++)
//{
//    Animal animal = new Animal;
//    animal = null;

//GC.Collect();//garbage collection tetiklenir fakat bazen bu kabul görmeybilir 
//}

//Utu utu = new Utu();
//utu.Marka = "Roventa";
//utu.Renk = "Beyaz";
//utu.KazanliMi = true;
//utu.Sicaklik = 0;

//string utuBilgileri =
//               $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" +
//               $"Marka : {utu.Marka}\n" +
//               $"Renk : {utu.Renk}\n" +
//               $"Sıcaklık : {utu.Sicaklik}\n" +
//               $"Kazanlı mı? : {(utu.KazanliMi ? "Var" : "Yok")}";
//Console.WriteLine(utuBilgileri);

//Console.WriteLine(new string('*', 100));
//Utu newUtu = new Utu("Arçelik", "KIrmızı", 0, true);

//Console.WriteLine(new string('*', 100));
//Utu utuMarka = new Utu("Bosch");
//utuMarka.Renk = "Mavi";
//utuMarka.Sicaklik = 10;
//utuMarka.KazanliMi = false;

//Console.WriteLine(new string('*', 100));
//Utu utuSinif = new Utu()
//{
//    Marka = "Fakir",
//    Renk = "Yeşil",
//    KazanliMi = true,
//    Sicaklik = 0,
//};
//utuSinif.Isın(25);

Person person = new Person();
person.Ad = "Sevgi";
person.Soyad = "Güçlü";
person.Email = "dfsfd@gmail.com";
person.Telefon = "5545645645";
person.DogumTarihi = DateTime.Now.AddYears(-27);
person.Cinsiyet = "Kadın";
person.Adres = "1257 street NewYork ABD";

//string personInfo = person.ToString();//abstract işlemi , tüm işlem arka tarfta dönüyor
string personInfo = person.getPersonInfo;
Console.WriteLine(personInfo);

