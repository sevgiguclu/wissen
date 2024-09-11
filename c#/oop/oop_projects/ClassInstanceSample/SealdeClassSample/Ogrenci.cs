using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdeClassSample
{
    public class Ogrenci : ILetisimBilgileri
    {
        //override dedikten sonra KisiBİlgileriniYaz() metodunu göremeyiz. ÇÜnkü IletisimBİlgileri sınıfında bu metodu sealed olarak işaretledik

        public Ogrenci()
        {
            //BU metodu çağırıp kullanabiliriz. fakat ezemeyeiz (override edemeyiz)
            KisiBİlgileriniYaz();
        }
    }
}
