using GenericsConsoleApp.Entities.Base;

namespace GenericsConsoleApp.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

