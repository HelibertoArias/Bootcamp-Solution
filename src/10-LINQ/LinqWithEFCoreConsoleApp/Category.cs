namespace LinqWithEFCoreConsoleApp;

public class Category
{
    public int CategoryId { get; set; }

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
    public string CategoryName { get; set; } = null!;
}

public class Product
{
    public int ProductId { get; set; }

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
    public string ProductName { get; set; } = null!;

    public int? CategoryId { get; set; }

    public decimal? UnitPrice { get; set; }
}

