using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelINterface
{
    interface IKisi
    {
        /*
        * interfacelerde property tanımlarken erişim belirleyici kullanmama gerek yok , sadece tipini ve değer adını yazmamız yeterli
        */
        int ID { get; set; }
        string Ad {  get; set; }
        string Soyad {  get; set; }
        string Departman {  get; set; }
        double Maas {  get; set; }

        string getInfo();//interfacelerde herhangi bir kod bloğu(body) olmaz
    }
}
