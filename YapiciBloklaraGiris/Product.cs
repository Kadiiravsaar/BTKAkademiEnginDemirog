using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciBloklaraGiris
{
    public class Product
    {
        int _id;
        string _name;
        public Product()
        {

        }
        public Product(int id, string name)
        {
            _id = id;
            _name = name;   
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
