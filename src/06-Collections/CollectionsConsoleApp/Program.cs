
using CollectionsConsoleApp;
using System.Collections;

Console.WriteLine("Collections demo\n");

// = = = = = = = = = = = = = = = = = = = = = = = =
// Array
// = = = = = = = = = = = = = = = = = = = = = = = =

string[] rgbs = new string[] { "Red", "Green", "Blue" };

string[] rgbColors = new string[3];
rgbColors[0] = "Red";
rgbColors[1] = "Green";
rgbColors[2] = "Blue";

foreach (string color in rgbs)
{
    Console.WriteLine($"Color: {color}");
}


// = = = = = = = = = = = = = = = = = = = = = = = =
// List
// = = = = = = = = = = = = = = = = = = = = = = = =
var listInts = new List<int>() { 1, 2 };
var colors = new List<string>();
colors.Add("Red");
colors.Add("Green");
colors.Add("Blue");

 

var newList = listInts.Select(number => number*2 +3).ToList();

// Remove by value
colors.Remove("Blue");

// Insert by index
colors.Insert(0, "Orange");

// Remove by index
colors.RemoveAt(colors.Count - 1);



string? oragenExists = colors.Find(c => !c.Equals("Orange"));
if (oragenExists != null)
{
    Console.WriteLine("Orange exist!");
}


// = = = = = = = = = = = = = = = = = = = = = = = =
// 
// = = = = = = = = = = = = = = = = = = = = = = = =

// Dictionary<TKey, TValue>
var dictionary = new Dictionary<string, string>();
dictionary.Add("r", "red");
dictionary.Add("g", "green");
dictionary.Add("b", "blue");


foreach (var item in dictionary)
{
    (string mykey, string myvalue) = item;

    Console.WriteLine($"color: {item}");
}

// fast search
string colorName = dictionary["r"];

Console.WriteLine($"colorName: {colorName}");



// = = = = = = = = = = = = = = = = = = = = = = = =
// stack
// = = = = = = = = = = = = = = = = = = = = = = = =

StackDemo.CreateAStack();


// = = = = = = = = = = = = = = = = = = = = = = = =
// Queue
// = = = = = = = = = = = = = = = = = = = = = = = =
Queue<string> q = new Queue<string>();
q.Enqueue("Two");
q.Enqueue("One");

// remove elements
while (q.Count > 0)
{
    Console.WriteLine(q.Dequeue());
}


Console.ReadLine();