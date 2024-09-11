using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdeClassSample
{
    public class BaseKitap
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //virtual kelimesi istenirse override edilecebileceğini istenemzse edilmeyebileceğini belirtir
        public virtual void GetLog()
        {
            Console.WriteLine("Kayıt Başladı");
        }

        public virtual void GetUser()
        {
            Console.WriteLine("Kullanıcı Bilgileri Getiriliyor.....");
        }
    }
}
