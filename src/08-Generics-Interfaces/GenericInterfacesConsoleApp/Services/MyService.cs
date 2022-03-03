using GenericInterfacesConsoleApp.Entities;
using GenericInterfacesConsoleApp.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfacesConsoleApp.Services;

public class MyService
{
    // Before implement IRepository
    //public void AddProduct(ListRepository<Product> productListRepository)
    //{
    //    productListRepository.Add(new Product { Id = 1, Name = "Nikon 3200" });
    //    var product = productListRepository.GetById(1);
    //    Console.WriteLine($"Your product {product.Name}");
    //}

    // After implement IRepository
    public void AddProduct(IRepository<Product> productListRepository)
    {
        productListRepository.Add(new Product { Id = 1, Name = "Nikon 3200" });
        var product = productListRepository.GetById(1);
        Console.WriteLine($"Your product {product.Name}");

        var result = productListRepository.GetAll();
        
    }
}

