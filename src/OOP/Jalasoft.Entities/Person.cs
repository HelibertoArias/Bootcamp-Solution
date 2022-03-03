using System;
namespace Jalasoft.Entities;

// Base class or superclass
public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string GetGreeting()
    {
        return "Hi,";
    }
}

 
