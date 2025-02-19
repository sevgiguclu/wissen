using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari
{
    public class DbOperationsManager : IDbOperations
    {
        /* normalde interfaceleri veri tipi olarak kullanmıyoruz, miras alıyoruz,
        * ama burda bu şekilde kullandığımız için interface i dışarıya karşı iletişime açmam gerekiyor
        */
        private IDbOperations _dbOperations;//dependency injection,property injection

        public DbOperationsManager(IDbOperations dbOperations)//dependency injection,constructor injection
        {
            _dbOperations = dbOperations;
        }

        public void Delete()
        {
           _dbOperations.Delete();
        }

        public void Insert()
        {
            _dbOperations.Insert();
        }

        public void Read()
        {
            _dbOperations.Read();
        }

        public void Update()
        {
            _dbOperations.Update();
        }
    }
}
