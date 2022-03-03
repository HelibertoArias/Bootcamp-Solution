using AttributesConsoleApp;
using System.Reflection;
using static System.Console;

WriteLine("Attributes");

var person = new Person("Jane", "Doe");

var sales = person.CalculateSales();


// Reading attribute
PropertyInfo lastNameProperty = typeof(Person).GetProperty(nameof(Person.LastName));

DisplayAttribute customAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(lastNameProperty, typeof(DisplayAttribute));

ForegroundColor = customAttribute.Color;

WriteLine("Testing color");

ReadLine();


