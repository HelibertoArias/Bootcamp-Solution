using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.Base;
using System.Linq;
namespace GenericMethodsConsoleApp.LINQDemo;

public static class LinqExamples
{
    public static void Run()
    {

        var productsList = new List<Product>();

        #region ListData 
        productsList.Add(new Product { Id = 2, Name = "Nikon Z5" });
        productsList.Add(new Product { Id = 3, Name = "Nikon Z6" });
        productsList.Add(new Product { Id = 1, Name = "Nikon Z7" });
        productsList.Add(new Product { Id = 5, Name = "Nikon Z8" });
        productsList.Add(new Product { Id = 4, Name = "Nikon Z9" });
        productsList.Add(new Product { Id = 6, Name = "Sonny Alpha 6400" });
        productsList.Add(new Product { Id = 7, Name = "Sonny SXC" });


        #endregion;


        var result = productsList.Find(x=>x.Id == 22);
        //var result1 = productsList.Single(x=>x.Id == 22);
        var result3 = productsList.Where(x=>x.Id == 22);

     
       



        //var productsFiltered = (from p in productsList
        //                       where p.Id > 2 && p.Name.Contains("Sonny")
        //                       orderby p.Id
        //                       select p).ToList();


        //var productsFiltered2 = productsList
        //                        .Where(FilterProduct)
        //                        .Select(x=> x.Id)
        //                        .OrderBy(x=> x )
        //                        .ToList();

        //var productsListFiltered3 = productsList
        //                                .OrderByDescending(x=>x.Id)
        //                                .ThenBy(x=>x.Name)
        //                                .ToList();

    }

    public static bool FilterProduct(Product p)
    {
        return p.Id > 2 && p.Name.Contains("Sonny");
    }
}


