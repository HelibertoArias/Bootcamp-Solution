using GenericInterfacesConsoleApp.Entities.Base;

namespace GenericInterfacesConsoleApp.Repositories.Base;

// TODO: Change to IRepository 
public class ListRepository<T> : IRepository<T> where T : class, IEntity
 
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
        Console.WriteLine("Running ListRepository.GetById with IRepository");
        return _items.Single(x => x.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        
        return _items.ToList();
    }
}

 