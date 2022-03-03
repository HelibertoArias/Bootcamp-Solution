using GenericMethodsConsoleApp;
using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.IRepositories;
using GenericMethodsConsoleApp.Entities.IRepositories.Base;
using GenericMethodsConsoleApp.LINQDemo;
using GenericMethodsConsoleApp.Repositories;
using GenericMethodsConsoleApp.Repositories.Base;
using GenericMethodsConsoleApp.Repositories.CosmoDB;
using GenericMethodsConsoleApp.Repositories.Lists;
using GenericMethodsConsoleApp.Repositories.SQLServer;
using GenericMethodsConsoleApp.Services;

Console.WriteLine("More generics!");


//Console.WriteLine("\n\n==== List Repository!");
//IProductRepository productListRepository = new ProductListRepository();

//ProductService productService1 = new ProductService(productListRepository);
//productService1.Run();


//Console.WriteLine("\n\n==== SQL Repository!");
//IProductRepository productSQLRepository = new ProductSQLRepository();

//ProductService productService2 = new ProductService(productSQLRepository);
//productService2.Run();


//IProductRepository productCosmoDB = new ProductCosmoDBRepository();
//ProductService ps = new ProductService(productCosmoDB);
//productService2.Run();

// Entities / DynamoDB Respositories / Service(IProductRepository, ICategoryRepository) (Autommaper Entity->DTO )-> DTO / Web API.
// Entities / CosmosDB Respositories / Service.




//var products = new List<Product>();
//products.Add(new Product { Id = 2, Name = "Nikon 3200" });
//products.Add(new Product { Id = 1, Name = "Nikon Z" });
//products.Add(new Product { Id = 3, Name = "Sonny 6400" });

//var categories = new List<Category>();
//categories.Add(new Category { Id = 2, Name = "Cameras" });
//categories.Add(new Category { Id = 1, Name = "Mirrorless" });


//var sortedProducts = ProductServiceExtensions.CustomSorting<Product>(products);

//var sortedCategories = ProductServiceExtensions.CustomSorting<Category>(categories);

//Console.ReadLine();
 









//var sortProducts = ServiceExtensions.CustomSorting<Product>(products);
//var categories = new List<Category>();
//categories.Add(new Category { Id = 2, Name = "Cameras" });
//categories.Add(new Category { Id = 1, Name = "Mirrorless" });



//var sortCategories = ServiceExtensions.CustomSorting<Category>(categories);


/*
    TODO: Add the CategorySQLRepository and CategoryListRepository
    

 */

 LinqExamples.Run();



Console.ReadLine();