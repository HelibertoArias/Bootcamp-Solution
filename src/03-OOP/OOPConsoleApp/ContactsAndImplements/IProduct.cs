

namespace OOPConsoleApp.ContactsAndImplements;

public interface IProduct
{
    // Before C# 8.0
    //void Sell();        

    // After C# 8.0
    void Sell() { Console.WriteLine("Update stock"); }
}

public class Chair : IProduct
{
    public void Sell()
    {
        Console.WriteLine("Take out of the deposit");
    }
}

public class Car : IProduct
{
    //public void Sell()
    //{
    //    Console.WriteLine("Request import");
    //}
}