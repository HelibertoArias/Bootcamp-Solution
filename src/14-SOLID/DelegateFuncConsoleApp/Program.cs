/*
 * Delegate 
 *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
 * How to declare, instantiate, and use a Delegate  
 *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/how-to-declare-instantiate-and-use-a-delegate
*/

//Console.WriteLine("Delegates!");


//var demo01 = new Demo01();
//demo01.SetGreet(32, "HellO DElegates!"); // lowercase
//                                         //demo01.SetGreet(0, "HellO DElegates!"); // not changes
//                                         //demo01.SetGreet(1, "HellO DElegates!"); // uppercase
//                                         //demo01.SetGreet(2, "HellO DElegates!"); // lowercase, not changes, uppercase






























//using DelegateFuncConsoleApp;

//Console.WriteLine("Testing subscritions!");

//var email = new Email();
//email.Send();




































using DelegateFuncConsoleApp;

var logger = new Logger();
var email = new Email();

email.Sent += logger.Email_OnSent;//subscribe to the event


email.Send();




Console.ReadLine();