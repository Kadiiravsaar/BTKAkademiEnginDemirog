using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            PersonManager2 personManager2 = new PersonManager2();

            Customer customer = new Customer
            {
                Id = 1,
                Name = "Kadir",
                SurName = "Avşar",
                Adress = "Gop"
            };
            personManager.Add(customer);

            //Studend studend = new Studend
            //{
            //    Id = 1,
            //    Name = "Kadir",
            //    SurName = "Avşar",
            //    Departman = "Gop"
            //};
            //personManager.Add(studend); // burası patlar çünkü aşağıda personmanager clasın
            //içerisine biz customer verdik
            // peki nasıl çözerdik:  personmanager yerine IPerson vermeliydik

            //Student student = new Student
            //{
            //    Id = 1,
            //    Name = "Kadir",
            //    SurName = "Avşar",
            //    Departman = "Gop"
            //};
            //personManager2.Add(student);

            //Console.WriteLine("////////////////////////////////////////////////////////////////");///////////////////////////

            //CustomerManager customerManager = new CustomerManager();

            //customerManager.Add(new SqlServerCustomerDal());

            //Console.WriteLine("////////////////////////////////////////////////////////////////");///////////////////////////


            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServer(),
                new Oracle()
            };
            foreach (var custom in customerDals)
            {
                custom.Add();
            }

            Console.ReadLine();

        }


        interface IPerson // soyut nesne
        {
            int Id { get; set; }
            string Name { get; set; }
            string SurName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }

            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public string Departman { get; set; }

        }

        class PersonManager
        {

            public void Add(Customer customer)
            {
                Console.WriteLine(customer.Name);
            }

        }
        class PersonManager2
        {

            public void Add(IPerson person)
            {
                Console.WriteLine(person.Name);
            }

        }
    }
}
