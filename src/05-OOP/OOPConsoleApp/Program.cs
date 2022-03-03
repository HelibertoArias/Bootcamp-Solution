using OOPConsoleApp;
using OOPConsoleApp.Entities;
using OOPConsoleApp.Entities.Interfaces;

Console.WriteLine("Implicit and explicit casting");

var washingMachine = new WashingMachine();
var ebook = new ElectronicBook();


if (washingMachine is IProduct && washingMachine is IPhysicalProduct)
{
    Console.WriteLine("WashingMachine is a IProduct and IPhysicalProduct");
}
else if (washingMachine is IProduct)
{
    Console.WriteLine("WashingMachine is a IProduct");
}
else
{
    Console.WriteLine("WashingMachine is NOT a IProduct");
}

Console.ReadLine();

