using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Uptaded");
        }
    }
    class Oracle : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Uptaded");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }

}
