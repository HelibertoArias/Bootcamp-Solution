

// See https://aka.ms/new-console-template for more information
using OOPConsoleApp.Entities;

Console.WriteLine("Hello, World!");

//Person p1 = new("John", 22);

//p1.Name = "Peter";

//var test = p1.MinAge;
 


//Person p2 = new("Mario", 33);
//Console.WriteLine($"Max children : {p1.GetMaxChildren()}"); 

////Setting a static variable 
//Person.MAX_CHILDREN = 2;
//Console.WriteLine($"Max children : {p2.GetMaxChildren()}");

//// Is not possible change a const values
//// p1.Species = "New specie";


var person = new Person() { 
    Name = "Judy", 
    LastName = "Foster", 
    Age = 33,
    

    // Private
     //Dummy = 2,

    // Private set
    // MinAge = 22
};

person.AddChildrenData();

Console.WriteLine($"Mother: {person.Name}");

var index = 0;

// Controlling access using indexers
Console.WriteLine($"First child (before) {person[index].Name}");

person[index].Name = "Indexer Jose";
Console.WriteLine($"First child  (after) {person[index].Name}");



// Deconstructing tuples
(string course, int score) = person.LastScore();
Console.WriteLine($"Last score : {score} in {course}");


var tupleWithoutNames = person.LastScore();
Console.WriteLine($"Last score : {tupleWithoutNames.Item2} in {tupleWithoutNames.Item1}");

// Deconstructing tuple named
(string course2, int score2) = person.LastScoreWithNames();

// A better way.
var lastScoreWithName = person.LastScoreWithNames();

Console.WriteLine($"Last score : {score2} in {course2}");
Console.WriteLine($"Last score : {lastScoreWithName.score} in {lastScoreWithName.course}");

Console.ReadLine();
