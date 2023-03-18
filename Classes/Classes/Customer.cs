using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {

        // public int Id; // bu bir field

        public int Id { get; set; } // bu bir propdur.

        private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        // ben bir kural getiriyorum eğer kullanıcı FirstName set ederse başa Mr gelsin diyorum.
        // burda "encapsulation" devreye girer
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
