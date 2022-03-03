using GenericMethodsConsoleApp.Entities.Base;
using GenericMethodsConsoleApp.Entities.IRepositories.Base;

namespace GenericMethodsConsoleApp.Repositories.Base;

public class CosmoDBRepository<T> : IRepository<T> where T : class, IEntityBase
{
    // CosmosDBContext = new...
    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        
    }
}

