
namespace OOPConsoleApp.StructVSClass;

//public struct Position
//{
//    public int X;
//    public int Y;

//    public Position(int x, int y)
//    {
//        this.X = x;
//        this.Y = y;
//    }
//}



public struct Position : IEquatable<Position>
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public bool Equals(Position other)
    {
        return this.X == other.X && this.Y == other.Y;
    }

     
}

