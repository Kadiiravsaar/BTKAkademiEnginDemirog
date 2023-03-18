using YapiciBloklaraGiris;
#region Örnek 1

CustomerManager customerManager = new CustomerManager(15);
customerManager.List();

#endregion

#region Örnek 2

Product produc1 = new Product { Id =1 , Name = "Laptop"};
Product product2 = new Product(2, "Computer");

#endregion
Console.WriteLine("-------------------------");
#region Örnek 3

//EmployeeManager employeeManager = new EmployeeManager();
//employeeManager.Logger = new Database();
//employeeManager.Add(); // 1. Yol



Worker worker = new Worker(new Database());
worker.Add();


#endregion
