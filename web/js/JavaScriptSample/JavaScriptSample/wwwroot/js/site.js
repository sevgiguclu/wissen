//Veri Tipleri
//var degisken = "Merhaba Dünya!!!";
//degisken = 25;
//degisken = true;
//degisken = "Tekrar Merhaba";

//let degisken2 = 'Değişken tanımlamak için diğer anahtar kelime';
//degisken2 = 'Tekrar değişkendeğerini değiştirelim';

//const sabit = 'Constant Variable'; //Değiştirilemez, sabit veriler için kullanılır

//console.log(degisken);
//console.log(degisken2);
//console.log(sabit);



//İlkel Veri Tipleri(Primitive)
//var str = 'STRING';
//var number = 25;
//var dogruMU = true;
//var bos = null;
//var sayiDegil = NaN;
//var tanimsiz = undefined;

//console.log(str);
//console.log(number);
//console.log(dogruMU);
//console.log(bos);
//console.log(sayiDegil);
//console.log(tanimsiz);

//Başvuru Veri Tipleri(Complex-Object)

//var myObj = {
//    name: 'John Doe',
//    age: 35,
//    isDeveloper : true
//}
//console.log(myObj);

//Property den değer okumak
//console.log(myObj["age"]);
//console.log(myObj.name);

//Yeni bir property ekleme
//myObj.country = 'Türkiye';
//console.log(myObj);

//Property Silme
//delete myObj.isDeveloper;
//console.log(myObj);

//Property Değerini Değiştirme
//myObj.name = 'Jeyn Doe';
//console.log(myObj);

//Dizi İşlemleri
/*
var myArr = ['John', 'Doe', 18, 20, true, false, null, NaN];
console.log(myArr);
//Index numarasına göre değer okuma
console.log(myArr[0]);
console.log(myArr[4]);
console.log(myArr[10]);//undefined index için dizide eleman bulunmuyor

myArr[0] = 15;
console.log(myArr);

//Eleman Ekleme
//En sona eleman ekleme
myArr.push('Yeni Eklenen');
console.log(myArr);

//En başa eleman ekleme
myArr.unshift('Birinci Eklenen');
console.log(myArr);

//Eleman Çıkartmak
//En sondaki elemanı diziden çıkartma
myArr.pop();
console.log(myArr);

//En baştaki elemanı diziden çıkartma
myArr.shift();
console.log(myArr);

//Belli bir indexden başlayıp belli sayıdaki değeri diziden çıkartma
myArr.splice(1, 2);
console.log(myArr);
*/

//Matematiksel Operatörler
/*
//Toplam
var sum = 25 + 12;
console.log(sum);

//Çıkartma
var sub = 25 - 12;
console.log(sub);

//Çarpma
var multiple = 20 * 4;
console.log(multiple);

//Bölme 
var div = 36 / 6;
console.log(div);

//Mod Alma
var mod = 35 % 2
console.log(mod);

//Üst Alma
var pov = 2 ** 3;
console.log(pov);
*/


//Matematiksel Kısayol Operatörleri
/*
var sayi = 4;
sayi += 4;
console.log(sayi);
sayi -= 2;
console.log(sayi);
sayi *= 3;
console.log(sayi);
sayi /= 4;
console.log(sayi);

sayi++;//sayi+=1
console.log(sayi);
sayi--;//sayi -=1
console.log(sayi);
*/

//Conditional Operatörler
/*
var sayi1 = 13;
var sayi2 = 7;

var con1 = sayi1 > sayi2;
console.log(con1);

var con2 = sayi1 < sayi2;
console.log(con2);

var con3 = sayi1 <= sayi2;
console.log(con3);

var con4 = sayi1 >= sayi2
console.log(con4);

var con5 = sayi1 == sayi2;
console.log(con5);
*/

//var con = 'Hello' == 'hello';
//console.log(con);

//var con = '25' == 25;
//console.log(con);

//var strSayi = '26';
//var numSayi = 26;
//console.log(strSayi + numSayi);
//var con1 = numSayi == strSayi;
//console.log(con1);

//var con = '27' === 27;//Strict eşitlik kontrolü
//console.log(con);

//var con = '42' != 42;
//console.log(con);

//var con1 = '44' !== 44;
//console.log(con1);

//var con = 'Hello' !== 'Hello World!!';
//console.log(con);

//If Statement
/*
if (3 > 5) {
    console.log('3 büyüktür 5');
}


if (3 < 5) {
    console.log("3 küçüktür 5' ten")
}
*/

//var mesaj = 'Merhaba';
//if (mesaj === 'Merhaba') {
//    console.log('Mesajınız : Merhaba');
//}

//If - Else
/*
var age = 45;
if (age >= 65) {
    console.log('65 yaş üstü')
}
else {
    console.log('65 yaş altı');
}
*/

//if - else if -else
//var age = 11;
//if (age >= 50)
//    console.log('Yaş 50\' ye eşit ve ya 50\' den büyüktür..');
//else if (age >= 18) {
//    console.log('Yaş 18\' e eşit vaya 18\' den büyüktür');
//}
//else {
//    console.log('Yaş 11\' den küçüktür');
//}

//Switch Case
//var firstName = 'John'
//switch (firstName){
//    case 'Jeyn':
//        console.log('Sen Jeyn sin');
//        break;
//    case 'Tom':
//        console.log('Sen Tom sun');
//        break;
//    case 'Poul':
//        console.log('Sen Poul sun');
//        break;
//    default:
//        console.log('Sen Kimsin');
//        break;
//}

//Döngüler
//For
//var loopArray = ['John', 'Jeyn', 'Bill', 'Poul'];
//for (var i = 0; i < loopArray.length; i++) {
//    console.log((i + 1) + '. isim : ' + loopArray[i]);
//}

//var ve let
//var keyword ü global scope ta ya da function scope ta değişken yaratmak için kullanılır
//let keyword ü block scope ta değişken yaratmak için kullanılır

//var z = 3;
//for (let z = 0; z < 5; z++) {
//    console.log('z : ' + z);
//}

//console.log('Global z : ' + z);

//let yas = 20;
//while (yas <= 60) {
//    console.log('Yaş : ' + yas + '. Hala  emekli değilsin...');
//    yas++;
//}
//console.log('Yaş : ' + yas + '. Artık emekli olabilirsin....');


//let yas = 85;
//do {
//    console.log('65\' ten küçüksün')
//    yas++;
//}while(yas < 75 )

//FUNCTIONS
//function add() {
//    console.log('Toplam FOnksiyonu : ' , 4 + 5);
//}
//add();

//function carpım(n) {
//    console.log('Girilen değerin 2 katı : ' + (n * 2));
//}
//carpım(23);
//carpım(30);
//carpım('John');

//function ikiParametre(x, y) {
//    console.log('X * Y : ' + (x * y));
//}
//ikiParametre(3, 2);
//ikiParametre(3, 'John');

function conditionalSum(a, b) {
    console.log('a değerinin number olup olmadığı kontrol ediliyor...');
    if (typeof a !== 'number') {
        console.log('a değişkeni bir number değil!!!!');
        return;
    }

    console.log('a değişkeninin 10\' dan büyük olup olmadığı kontrol ediliyor....');
    if (a >= 10) {
        return a + b;
    }

    console.log('a değişkeni 10\' dan küçük...');
    return 10 + a + b;
}

const result1 = conditionalSum('Hello', 5);
console.log(result1);

const result2 = conditionalSum(22, 5);
console.log(result2);

const result3 = conditionalSum(2, 5);
console.log(result3);