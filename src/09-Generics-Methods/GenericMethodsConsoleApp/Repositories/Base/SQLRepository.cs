using GenericMethodsConsoleApp.Entities.Base;
using GenericMethodsConsoleApp.Entities.IRepositories.Base;

namespace GenericMethodsConsoleApp.Repositories.Base;

public class SQLRepository<T> : IRepository<T> where T : class, IEntityBase
{
    private readonly List<T> _items = new();


    public void Add(T item)
    {
        Console.WriteLine("Adding using SQLRepository");
        _items.Add(item);
    }

    public void Save()
    {
        Console.WriteLine("Saving using SQLRepository");
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }

    public T GetById(int id)
    {
        var item = _items.Single(x => x.Id == id);
        Console.WriteLine($"GetById  using SQLRepositorys. Id:{item.Id}");
        return _items.Single(x => x.Id == id);
    }

    public IEnumerable<T> GetAll()
    {

        return _items.ToList();
    }
}

