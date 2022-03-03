using GenericsConsoleApp.Entities;
using GenericsConsoleApp.Repositories.Base;

namespace GenericsConsoleApp.Repositories;

public class ProductRepository //: GenericRepository<Product>
{
    private readonly List<Product> _items = new();

    public void Add(Product item)
    {
        _items.Add(item);
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }


}



