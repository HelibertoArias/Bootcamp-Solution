using GenericMethodsConsoleApp.Entities.Base;

namespace GenericMethodsConsoleApp.Entities.IRepositories.Base;

public interface IRepository<T> where T : class, IEntityBase
{
    IEnumerable<T> GetAll();
    void Add(T item);
    T GetById(int id);
    void Save();
}

