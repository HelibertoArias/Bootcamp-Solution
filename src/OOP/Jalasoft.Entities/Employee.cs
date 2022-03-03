using System;

namespace Jalasoft.Entities;

// Subclass or derived class
public class Employee : Person
{
    public string Department { get; set; }

    public double GetCalculateSalary()
    {
        // TODO : Here your operation
        return 0.0;
    }

    public void ShowInfo()
    {
       
        var message = $"{GetGreeting()} I am {Name} and I work in the {Department}.";
        Console.WriteLine(message);
    }
}


