using OOPConsoleApp.ContactsAndImplements;
using OOPConsoleApp.Entities;
using OOPConsoleApp.Extensions;
using OOPConsoleApp.Helpers;
using OOPConsoleApp.StructVSClass;

Console.WriteLine("Demo 03-OOP");

// = = = = = = = = = = = = = = = = = = = = = = = =
// 
// = = = = = = = = = = = = = = = = = = = = = = = =

//Product product = new();


// = = = = = = = = = = = = = = = = = = = = = = = =
// Static method
// = = = = = = = = = = = = = = = = = = = = = = = =

// Bad
// var gui = StringHelper.GetUniqueIdentifier();

// Good
//string gui = StringHelper.GetUniqueIdentifier();
//Console.WriteLine(gui);

// = = = = = = = = = = = = = = = = = = = = = = = =
// Extensions
// = = = = = = = = = = = = = = = = = = = = = = = =

//using OOPConsoleApp.Extensions;
//Using System.Linq namespace
//int[] ints = { 3, 45, 3, 39, 1 };

//var result = ints.OrderBy(g => g);

//foreach (var i in result)
//{
//    System.Console.Write(i + " ");
//}


// = = = = = = = = = = = = = = = = = = = = = = = =
// Custom Extensions
// = = = = = = = = = = = = = = = = = = = = = = = =

//var sentence = "Hey, I'm here!.";
//var wordscount = sentence.WordCount();
//Console.WriteLine($"wordscount: {wordscount}");



//var options = new string[] {"Option 1",
//                            "Option 2",
//                            "Option 3" };

//var firstOption = options.GetFirstItem();
//Console.WriteLine(firstOption);

//var intWeekDay = 3;
//Console.WriteLine(intWeekDay.GetNameWeekDay());


// = = = = = = = = = = = = = = = = = = = = = = = =
// Structs
// = = = = = = = = = = = = = = = = = = = = = = = =
//Position p1 = new Position(10, 20);
//Position p2 = new Position(11, 20);

// //var isSamePosition = (p1 == p2); // Compile-time error!

// var isSamePosition =  p1.Equals(p2); //  implementing IEquatable


//Console.WriteLine($"Position p1.X: {p1.X}");

// = = = = = = = = = = = = = = = = = = = = = = = =
// Record
// = = = = = = = = = = = = = = = = = = = = = = = =

// RecPosition r1 = new RecPosition(10, 20);
// Console.WriteLine(r1.X);
//// Fails
//// r1.X = 12;

// RecPosition r2 = new RecPosition(10, 20);

//if (r2 == r1) //
//{
//    Console.WriteLine("r1 is equal to r2");
//}

//var rec = new RecPositionVerboseMutable();
//rec.X = 3;
//rec.Y = 4;
var xx = new RecPositionVerboseInmutable();
 
// = = = = = = = = = = = = = = = = = = = = = = = =
// Interface
// = = = = = = = = = = = = = = = = = = = = = = = =

IProduct chair = new Chair();
IProduct car = new Car();

Console.WriteLine("\nCall sell method per instance");
chair.Sell();
car.Sell();

var productsArray = new IProduct[2];
productsArray[0] = chair;
productsArray[1] = car;

Console.WriteLine("\nPrinting using array");

foreach (var product in productsArray)
{
    product.Sell();
}

Console.WriteLine("\nPrinting using list");

var products = new List<IProduct>() { chair, car };
products.Add(chair);

var products2 = new List<IProduct>();

try
{
    products2.Add(chair);
    products2.Add(car);
    products2.Add(chair);
    products2.Add(car);
    products2.Add(chair);
    products2.Add(car);
}
catch (Exception ex)
{

    Console.WriteLine("Error adding records");
    throw; 
}
finally
{
    products2.Clear();
}


foreach (var product in products)
{
    product.Sell();
}