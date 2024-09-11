using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    //enumlar default olarak int türündedir
    //pek değişmeyecek yapıları databaseden çekmek yerine enum ile kullanabiliriz
    // enumlar default olarak int olduğu için int karşılaştırma  yaparak string karşılaştırmaya göre daha hızlıdır 
    public enum Aylar
    {
        //default olarak 0dan başlar fakat başta değer verirseniz o şekilde devam eder 
        Ocak = 1, //valuesu 1 name i Ocak
        Şubat,
        Mart,
        Nisan,
        Mayıs,
        Haziran,
        Temmuz,
        Ağustos,
        Eylül,
        Ekim,
        Kasım,
        Aralık
    }
}
