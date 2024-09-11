using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari
{
    //dışarıya karşı iletişimi açmak için public tanımlanık, veritipi şeklinde kullandık DbOperationsManager kısmında
    public interface IDbOperations
    {
        void Insert();
        void Update();
        void Delete();
        void Read();

    }
}
