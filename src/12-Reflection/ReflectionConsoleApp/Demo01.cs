using System;
using static System.Console;
namespace ReflectionConsoleApp;



public class EmployeeAttribute : Attribute
{

}


[Employee]
public class Employee : Person
{
    public string Company { get; set; }
}

public class Person
{
    public string FirstName { get; set; }
    public string Id { get; set; }

    public Person()
    {
        WriteLine("Person default constructor");
    }

    public Person(string firstName)
    {
        FirstName = firstName;
        WriteLine("Person constructor with firsname");
    }

    private Person(string firstName, int id)
    {
        FirstName = firstName;
        Id = Id;
        WriteLine("Person constructor private with firsname and id");
    }

    public void Greet() { WriteLine("Greet");  }

    public void Bye(string text) { WriteLine( $"Bye {text}.");  }

    protected void Yell() { WriteLine("Yell"); }
}


public interface IProduct
{
    void SetPrice(int tax);
}

public class Book : IProduct
{
    public void SetPrice(int tax)
    {
        WriteLine($"Setting the price with tax: {tax}.");
    }
}

public class WashingMachine : IProduct
{
    public void SetPrice(int tax)
    {
        WriteLine($"Setting the price with tax: {tax}.");
    }
}




