
namespace OOPConsoleApp.StructVSClass;


// Records in C# 9.0
public record RecPosition(int X, int Y);

public record RecPositionVerboseInmutable
{
    // Use init for inmutable properties
    public int X { get; init; }
    public int Y { get; init; }     
};


public record RecPositionVerboseMutable
{
    // Mutable properties
    public int X { get; set; }
    public int Y { get; set; }
}

