using GenericMethodsConsoleApp.Entities.Base;

namespace GenericMethodsConsoleApp.Entities;

public class Product : EntityBase
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Name :{Name}";
    }
}

