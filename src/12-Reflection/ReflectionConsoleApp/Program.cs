// See https://aka.ms/new-console-template for more information

using ReflectionConsoleApp;
using System.Reflection;
using static System.Console;

WriteLine("Reflection\n");


//=
// Get name of a type
//=

//string name = "Jane Doe";

//// abstract class Type : MemberInfo, IReflect
////var stringType = name.GetType();
//var stringType = typeof(string);

//WriteLine(stringType);



//=
// Get name of a type
//=
//WriteLine("\nAssembly\n");

//var currentAssembly = Assembly.GetExecutingAssembly();

//var typesFromCurrentAssembly = currentAssembly.GetTypes();

//WriteLine($"Current assemply  name {currentAssembly}");

//foreach (var type in typesFromCurrentAssembly)
//{
//    WriteLine(type.Name);
//}




//=
// Getting a type Person
//=
//var currentAssembly = Assembly.GetExecutingAssembly();
//var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionConsoleApp.Person");

//WriteLine($"Current type {oneTypeFromCurrentAssembly.Name} ");


//=
// Loading External assemblies
//=

//var externalAssembly = Assembly.Load("System.Text.Json");
//var typesFromExternalAssembly = externalAssembly.GetTypes();
//var oneTypeFromExternalAssembly = externalAssembly.GetType("System.Text.Json.JsonProperty");

//var modulesFromExternalAssembly = externalAssembly.GetModules();
//var oneModulesFromExternalAssembly = externalAssembly.GetModule("System.Text.Json.dll");



//=
// Get constructor and methos for person
//=
//var currentAssembly = Assembly.GetExecutingAssembly();
//var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionConsoleApp.Person");


//WriteLine("\nConstructor for Person type");
//foreach (var constructor in oneTypeFromCurrentAssembly.GetConstructors())
//{
//    WriteLine(constructor);
//}

//WriteLine("\nMethods for Person type");
//foreach (var method in oneTypeFromCurrentAssembly.GetMethods())
//{
//    WriteLine(method);
//}



//=
// Get constructor and methos for person (Includes private and protected
//=
//var currentAssembly = Assembly.GetExecutingAssembly();
//var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionConsoleApp.Person");

//WriteLine("\nConstructor for Person type");
//foreach (var constructor in oneTypeFromCurrentAssembly.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
//{
//    WriteLine(constructor);
//}

//WriteLine("\nMethods for Person type");
//foreach (var methods in oneTypeFromCurrentAssembly.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
//{
//    WriteLine(methods);
//}


//=
// Call a method
//=
//var currentAssembly = Assembly.GetExecutingAssembly();
//var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionConsoleApp.Person");

//WriteLine("\nCalling the by Method for Person type");

//var personTest = new Person();

//var methodByeInPerson = oneTypeFromCurrentAssembly.GetMethod("Bye");

//string[] values = new string[] { "Jane Doe" };
//methodByeInPerson.Invoke(personTest, values);

ReadLine();









