
using Koleksiyonlar;

List<string> cities = new List<string>(); // Ben bir koleksiyon oluşturmak istiyorum dizi temelli olsun ve sadece string ile çalışabiliyorum


//List<Customer> customers = new List<Customer>();
//customers.Add(new Customer { Id = 2, Name = "Kadir" });

List<Customer> customers = new List<Customer>()
{
    new Customer {Id=1,Name ="Kadir"},
    new Customer {Id=2,Name ="Ali"}
};

var count = customers.Count();

foreach (var cst in customers)
{
    Console.WriteLine(cst.Name);
}