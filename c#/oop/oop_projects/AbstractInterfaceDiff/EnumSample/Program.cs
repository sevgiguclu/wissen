// See https://aka.ms/new-console-template for more information


using EnumSample;

//Console.WriteLine("Adını öğrenmek istediğiniz ay numarsını giriniz (1-12)");
//int ayNumarasi = int.Parse(Console.ReadLine());


////Enumdan indexe göre değer alınması iki şekilde olabilir:
//string secilenAy = Enum.GetName<Aylar>((Aylar)ayNumarasi).ToString();
//string secilenAy1 = Enum.GetName(typeof(Aylar), ayNumarasi);

//Console.WriteLine($"Seçtiğiniz Ay Numarası : {ayNumarasi}\n" + $"Ay : {secilenAy}");

////Bütün name değeleri alamak istersek;
//string[] items = Enum.GetNames(typeof(Aylar));
//foreach (var item in items)
//{
//    Console.WriteLine(item);
//}

////listenin value değerlerini almak istersek;

//int[] values = (int[]) Enum.GetValues(typeof(Aylar));
//foreach (var item in values)
//{
//    Console.WriteLine(item);
//}

////enum ile oluşturduğum yapıyı bir listeye atabilirim
//List<string> gunlerListesi = new List<string>(Enum.GetNames(typeof(Aylar)));
//foreach (var item in gunlerListesi)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(Gunler.Cuma.ToString());
//Console.WriteLine(Renkler.Kırmızı.ToString());

//EnumExtensions sınıfını ve GetDisplayName metodunu biz oluşturduk 
Console.WriteLine(EnumExtensions.GetDisplayName(Renkler.SariveMavi));

