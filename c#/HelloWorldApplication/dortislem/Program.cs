// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


#region Dört işlem ve etiket kullanımı (goto)

////etiketler artık kullanılmıyor biz bunları döngülerle yapıyoruz
//int sayi1,sayi2;
//char islem;// + - * / 
////char türündeki veriler '' ile yazılır
//string mesaj = string.Empty;//string mesaj = "";
//int sonuc;


//Console.WriteLine("Yapmak istediğiniz işlemi giriniz [ + , - , * , / ]");
//islem = char.Parse(Console.ReadLine());
//bool islemSonuc = islem == '+' || islem == '-' || islem=='*' || islem == '/';
//mesaj = !islemSonuc ? "yanlış girdiniz.." : "yapmak istediğiniz işlem alınmıştır.. \n sonuc: ";
    

//if(!islemSonuc)
//{
//    goto islemYanlisSecildi;
//}
//else
//{
//    goto islemYap;
//}

//islemYanlisSecildi:
//    Console.WriteLine(mesaj);
//    //Console.ReadLine();
//    Environment.Exit(0);//uygulamadan çıkar
//islemYap:
//    Console.Write("ilk sayıyı giriniz : ");
//    sayi1 = int.Parse(Console.ReadLine());
//    Console.Write("ikinci sayıyı giriniz : ");
//    sayi2 = int.Parse(Console.ReadLine());
//    sonuc = (islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1 - sayi2 : (islem == '*' ? sayi1 * sayi2 : sayi1 / sayi2)));
//    Console.WriteLine(mesaj);
//    Console.Write(sonuc);


#endregion

#region tür dönüşümleri

int sayi = 1000;
byte dsayi = (byte)sayi;
Console.WriteLine(dsayi);

int sayi_2 = 255;
byte dsayi_2 = (byte)sayi_2;
Console.WriteLine(dsayi_2);

bool dogru = true;
Console.WriteLine(dogru);
Console.WriteLine(dogru.ToString());
Console.WriteLine(Convert.ToByte(dogru));
Console.WriteLine(Convert.ToInt32(dogru));
Console.WriteLine(Convert.ToDouble(dogru));
Console.WriteLine(Convert.ToInt64(dogru));

string s_sayi = "2000";
short short_sayi = Convert.ToInt16(s_sayi);
int int_sayi = Convert.ToInt32(s_sayi);
long l_sayi = Convert.ToInt64(s_sayi);

Console.WriteLine(short_sayi);
Console.WriteLine(int_sayi);
Console.WriteLine(l_sayi);

string number = "1000,75";
double dd_num = Convert.ToDouble(number);
float f_num = Convert.ToSingle(number);
decimal d_num = Convert.ToDecimal(number);

Console.WriteLine(dd_num);
Console.WriteLine(f_num);
Console.WriteLine(d_num);


#endregion