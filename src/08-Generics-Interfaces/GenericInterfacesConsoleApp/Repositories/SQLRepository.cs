using GenericInterfacesConsoleApp.Entities.Base;

namespace GenericInterfacesConsoleApp.Repositories.Base;

public class SQLRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly List<T> _items = new();


    public void Add(T item)
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

    public T GetById(int id)
    {
        Console.WriteLine("Running SQLRepository.GetById");
        return _items.Single(x => x.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        //return _items;
        return _items.ToList();
    }

    
}

