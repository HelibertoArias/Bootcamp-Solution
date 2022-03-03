using GenericsConsoleApp.Entities.Base;

namespace GenericsConsoleApp.Entities;

public class Category: BaseEntity
{
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
