using GenericInterfacesConsoleApp.Entities.Base;
 
namespace GenericInterfacesConsoleApp.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }
    

    public override string ToString()
    {
        return Name;
    }
}
