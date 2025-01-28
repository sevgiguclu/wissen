// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region array list 
using Microsoft.VisualBasic;
using System.Collections;


////farklı türdeki öğeleri saklayabilen dinamik boyutlu(çalışma anında boyutu değişebilir) collection
//ArrayList gunler = new ArrayList();
//gunler.Add("pazartesi");
//gunler.Add("salı");
//gunler.Add("çarşamba");
//gunler.Add("perşmebe");
//gunler.Add("cuma");
//gunler.Add("cumartesi");
//gunler.Add("pazar");

//int[] dizi = new int[] { 100, 200, 300, 400, 500 };
////string değerleri olan collectiona int türünde veri ekledik
//gunler.AddRange(dizi);

//Console.WriteLine("-------------------eleman sayısı-------------------");
//Console.WriteLine($"eleman sayısı : {gunler.Count}");
//Console.WriteLine("-------------------kapasite sayısı-------------------");
//Console.WriteLine($"eleman sayısı : {gunler.Capacity}");

//gunler.Add("sevgi");
//gunler.Add("sevgi");
//gunler.Add("berkay");
//gunler.Add("sevgi");
//gunler.Add("sevgi");

//Console.WriteLine("-------------------eleman sayısı-------------------");
//Console.WriteLine($"eleman sayısı : {gunler.Count}");
//Console.WriteLine("-------------------kapasite sayısı-------------------");
//Console.WriteLine($"eleman sayısı : {gunler.Capacity}");

////kapasiteyi eleman sayısına eşitlemek için
//gunler.TrimToSize();
//Console.WriteLine("-------------------eleman sayısı-------------------");
//Console.WriteLine($"elemöan sayısı : {gunler.Count}");
//Console.WriteLine("-------------------kapasite sayısı-------------------");
//Console.WriteLine($"elemöan sayısı : {gunler.Capacity}");


//gunler.Clear();
//Console.WriteLine("-------------------eleman sayısı-------------------");
//Console.WriteLine($"elemöan sayısı : {gunler.Count}");
////elemanları sildik ama kapasite aynı sayıda kaldı, gereksiz yer saklıyor
//Console.WriteLine("-------------------kapasite sayısı-------------------");
//Console.WriteLine($"elemöan sayısı : {gunler.Capacity}");


//gunler.Sort();
////farklı veri türleri olduğu için sıralayamaz hata verir
//foreach (var item in gunler)
//{
//    Console.WriteLine(item);
//}

//gunler.Reverse();
//foreach (var item in gunler)
//{
//    Console.WriteLine(item);
//}

//bool result_1 = gunler.Contains("salı");
//bool result_2 = gunler.Contains("fdfg");
//Console.WriteLine(result_1);
//Console.WriteLine(result_2);

//int firstIndex = gunler.IndexOf("berkay");
//int lastIndex = gunler.LastIndexOf("pazartesi");

//Console.WriteLine(firstIndex);
//Console.WriteLine(lastIndex);

//gunler.Remove("pazartesi");//verilen değeri siler 
//gunler.RemoveAt(4);//index sayısına göre siler, olmayan index verildiğinde hata alınır çalışma durur


//gunler.Insert(5, "bir tane daha yeni gün yeniii ");//değeri istenilen indexe ekler
//gunler.InsertRange(1, new string[] { "pazartesi ertesi", "salı öncesi" });//collectionsı istenilen indexe ekler


//gunler.RemoveRange(1, 1);//başlangıç indexi,kaç tane silineceği


//string[] newString = new string[20];
//gunler.CopyTo(newString);//hangi collectiona kopyalanacağı
//gunler.CopyTo(newString, 5);//hangi array'e kopyalanacağı ve kopyalamaya kopyalama yapılacak arrayin hangi indexinden başlanacağı
//gunler.CopyTo(3, newString, 5, 5);//kopyalamaya kopyalancak olan dizinin hangi indexten başlayacağı , hangi array'e kopyalanacağı , kopyalamaya kopyalama yapılacak arrayin hangi indexinden başlanacağı, kaç tane eleman kopyalanacağı

//foreach (var item in newString)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in gunler)
//{
//    Console.WriteLine(item);
//}

//Console.ReadLine();

#endregion

#region dictionary

//Dictionary<int,string> iller = new Dictionary<int,string>();
//iller.Add(1, "adana");
//iller.Add(2, "antalta");
//iller.Add(34, "istanbul");
//iller.Add(35, "izmir");

//iller.Clear();
//Console.WriteLine($"elaman sayısı : {iller.Count}");

//bool result1 = iller.ContainsKey(1);
//bool result2 = iller.ContainsValue("ankara");

//Console.WriteLine(result1);
//Console.WriteLine(result2);


//Dictionary<int,string>.KeyCollection keys = iller.Keys;
//foreach (var item in keys)
//{
//    Console.WriteLine($"[{item}] : [{iller[item]}]");

//}

////iller koleksiyonunda key değeri 35 olan veri varsa il1'e atar ve true döndürür yoksa false döndürür
//bool result1 = iller.TryGetValue(35, out string il1);
//bool result2 = iller.TryGetValue(67,out string il2);

//Console.WriteLine($"{result1} - {result2}");  

//iller.Remove(1, out string il);

//Console.ReadLine();


#endregion

#region hashtable
Hashtable ogrenciList = new Hashtable();
ogrenciList.Add("240797", "sevgi ");
ogrenciList.Add("2407972", "berkay");
ogrenciList.Add("240757", "a");
////aynı key değeri ile tekrar ekleme yapmaya çalışırsan hata verir

//ogrenciList.Clear();
//bool result1 = ogrenciList.Contains("240797");
//bool result2 = ogrenciList.ContainsKey("240757");
//bool result3 = ogrenciList.ContainsValue("sevgi");

//Console.WriteLine(result1  + "-" + result2 + "-" + result3);

//ICollection keys = ogrenciList.Keys;
//ICollection values = ogrenciList.Values;

//// hastable verileri hashlediği algoritmaya göre sıralar, sizin eklediğiniz sırayla değerli tutmaz
//foreach (string key in keys)
//{
//    Console.WriteLine(key);
//}

//ogrenciList.Remove("240757");

//object newObject = ogrenciList.Clone();
//Hashtable newOgrenciList  =  newObject as Hashtable;

//foreach (DictionaryEntry de in newOgrenciList)
//{
//    Console.WriteLine($"{de.Key} : {de.Value}");
//}


#endregion

#region sortedList 
//using System.Collections;

////tanımlama
SortedList iller = new SortedList();
//SortedList<int,string> _iller = new SortedList<int,string>();


iller.Add(34, "istanbul");
iller.Add(67, "zonguldak");
iller.Add(35, "izmir");
iller.Add(01, "adana");
iller.Add(53, "rize");


//iller.Clear();
//int elemanSayisi = iller.Count;

//IList keys =  iller.GetKeyList();
//IList values =  iller.GetValueList();
//foreach (int item in keys)
//{
//    Console.WriteLine(item);
//}


iller.Remove(53);
iller.RemoveAt(0);

bool result1 = iller.Contains(67);
bool result2 = iller.ContainsKey(35);
bool result3 = iller.ContainsValue("Zonguldak");

Console.WriteLine($"{result1} - {result2} - {result3}");

int key = (int)iller.GetKey(0);//index değeri verilen key değerini döndürür

Console.WriteLine(key);

foreach (var item in iller)
{
    Console.WriteLine(item);
}



#endregion