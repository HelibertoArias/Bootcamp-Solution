using GenericInterfacesConsoleApp.Entities.Base;

namespace GenericInterfacesConsoleApp.Repositories.Base
{
    public interface IRepository<T> where T : IEntity
    {
        /*
            - Namespace -> System.Collections.Generic
            - Implemented in all C# arrays
            - Generic collection class
            - LINQ support.
            - Iterable with a foreach loop            
             
         */
        IEnumerable<T> GetAll();
        void Add(T item);
        T GetById(int id);
        void Save();
    }
}