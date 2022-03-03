using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.IRepositories;
using GenericMethodsConsoleApp.Repositories.Base;

namespace GenericMethodsConsoleApp.Repositories.Lists;

public class ProductListRepository : ListRepository<Product>, IProductRepository
{
    public List<Product> GetTopTen()
    {
        return new List<Product>();
    }
}

