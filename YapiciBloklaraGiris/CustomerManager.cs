using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciBloklaraGiris
{
    public class CustomerManager
    {
        int _count; // private olduğu için alt çizgi kullandık. Standart.
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} Items" , _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
