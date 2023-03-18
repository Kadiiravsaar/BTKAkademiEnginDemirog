using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Kadir"; // burası set bloğu olur
            customer.LastName = "Avşar";
            customer.City = "İst";


            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "M",
                LastName = "A",
                City = "ist"
            };
            Console.WriteLine(customer.FirstName); // burası get bloğu olur
        }
    }
}
