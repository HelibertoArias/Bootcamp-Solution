using GenericsConsoleApp.Entities.Base;

namespace GenericsConsoleApp.Repositories.Base;

public class GenericRepository<T> where T : BaseEntity
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
        return _items.Single(x => x.Id == id);
    }
}