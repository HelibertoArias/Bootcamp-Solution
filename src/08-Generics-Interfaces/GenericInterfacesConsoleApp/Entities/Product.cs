using GenericInterfacesConsoleApp.Entities.Base;

namespace GenericInterfacesConsoleApp.Entities;

public class Product  : EntityBase
{
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

