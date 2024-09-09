// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int number;
int sqrtNumber;

Console.Write("Karesini hesaplamak istediğiniz tamsayıyı giriniz : ");
string strNumber = Console.ReadLine();

//number = Convert.ToInt32(strNumber);//kullannıcı çevirelemeyen değer girdiğinde kod çalışamayacak 
number = int.Parse(strNumber);//kullannıcı çevirelemeyen değer girdiğinde kod çalışamayacak 
sqrtNumber = number * number;

Console.WriteLine("Girdiğiniz sayının karesi : " + sqrtNumber);