using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithEFCoreConsoleApp
{
    public static class QueriesLINQ
    {
        public static void QueryFilterAndSortMethodSyntax()
        {
            using (NorthwindContext db = new ())
            {
                var products = db.Products;

                // M infers decimal conversion
                IQueryable<Product> filteredProducts = products
                                                        .Where(x => x.UnitPrice < 10M);

                IOrderedQueryable<Product> filterAndOrderedProducts = filteredProducts
                                                                        .OrderByDescending(x => x.UnitPrice);

                Console.WriteLine("\nProducts that cost less than $10:");
                foreach (var item in filterAndOrderedProducts)
                {
                    Console.WriteLine($"{item.ProductId}: {item.ProductName} cost {item.UnitPrice:$#,##0.00}");
                }
            }
        }


        public static void ProjectingFirstFiveProductsUsingAnonymousTypesMethodSyntax()
        {
            using (var db = new NorthwindContext())
            {
                var products = db.Products;
          
                var projection = products
                                    .OrderBy(x => x.ProductName)
                                    .Take(5)
                                    .Select(x => new
                                    {
                                        Id = x.CategoryId, //renaming
                                        Name = x.ProductName,  //renaming
                                        x.UnitPrice  //same name
                                    });


                Console.WriteLine("\nFirst Five products order asc by Name");
                foreach (var item in projection)
                {
                    Console.WriteLine($"{item.Id}: {item.Name} cost {item.UnitPrice:$#,##0.00}");
                }
            }
        }

        public static void JoinProductCategoriesMethodSyntax()
        {
            using (var db = new NorthwindContext())
            {
                // Product x Categories
                var productsCategories = db.Categories? // Left
                                        .Join(
                                                db.Products, // Right
                                                category => category.CategoryId,
                                                product => product.CategoryId,
                                                (category, product) => new
                                                {
                                                    Id = product.ProductId,
                                                    Product = product.ProductName,
                                                    Category = category.CategoryName
                                                })
                                        .OrderBy(x => x.Product)
                                        .ThenBy(x => x.Category)
                                        .Take(5);



                Console.WriteLine("\nProducts and categories");
                foreach (var item in productsCategories)
                {
                    Console.WriteLine($"{item.Id} - {item.Product} - {item.Category}");
                }
            }
        }

        public static void JoinProductCategoriesQuerySyntax()
        {
            using (var db = new NorthwindContext())
            {
                // Product x Categories
                var productsCategories = (from category in db.Categories
                                         join product in db.Products
                                         on category.CategoryId equals product.CategoryId
                                         // orderby product.ProductName
                                         select new
                                         {
                                             Id = product.ProductId,
                                             Product = product.ProductName,
                                             Category = category.CategoryName
                                         })
                                         .OrderBy(x => x.Product)
                                         .ThenBy(x => x.Category)
                                         .Take(5);



                Console.WriteLine("\nProducts and categories");
                foreach (var item in productsCategories)
                {
                    Console.WriteLine($"{item.Id} - {item.Product} - {item.Category}");
                }
            }
        }

        public static void ProductPerCategory()
        {
            using (var db = new NorthwindContext())
            {
                // Product x Categories
                var productsCategories = (from category in db.Categories
                                         join product in db.Products
                                         on category.CategoryId equals product.CategoryId
                                         group category by category.CategoryName into categoryGroup
                                         select new
                                         {
                                             CategoryName = categoryGroup.Key,
                                             TotalProducts = categoryGroup.Count()
                                         }).OrderByDescending(x=>x.TotalProducts)
                                         .Take(5);

                                           



                Console.WriteLine("\nTotal of Products per category");
                foreach (var item in productsCategories)
                {
                    Console.WriteLine($"{item.CategoryName} - {item.TotalProducts}");
                }
            }
        }

        public static void AggregatingSequences()
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine("\nAggregating sequences");
                Console.WriteLine($"Products total: {db.Products.Count()}");
                Console.WriteLine($"Max unit price: {db.Products.Max(x=>x.UnitPrice)}");
                Console.WriteLine($"Average unit price: {db.Products.Average(x=>x.UnitPrice)}");
            }
        }

        public static void UsingAnCustomLinqExtension()
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine("\nUsing a custom Linq extension");
                
                Console.WriteLine($"Lower unit price: {db.Products.GetLowerValue(x=>x.UnitPrice)}");
               
            }
        }

    }
}

public static class QueriesLinqExtension
{
    public static decimal? GetLowerValue<T>(this IEnumerable<T> sequence, Func<T, decimal?> selector)
    {
        // Here a fancy calculation
        return sequence.Min(selector);
    }
}
