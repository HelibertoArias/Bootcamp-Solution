
using GenericInterfacesConsoleApp;
using GenericInterfacesConsoleApp.Entities;
using GenericInterfacesConsoleApp.Entities.Base;
using GenericInterfacesConsoleApp.Repositories.Base;
using GenericInterfacesConsoleApp.Services;

Console.WriteLine("Implementing generic interfaces\n");

MyService ms = new MyService();

var productListRepository = new ListRepository<Product>();
ms.AddProduct(productListRepository);
Console.WriteLine();


//var productListRepository = new ListRepository<Product>();
//ms.AddProduct(productListRepository);
//Console.WriteLine();

//var productSQLRepository = new SQLRepository<Product>();
//ms.AddProduct(productSQLRepository);


