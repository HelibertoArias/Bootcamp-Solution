using RunningSynchrouslyConsoleApp;
using System.Diagnostics;
using static System.Console;

/*
 *  TaskFactory.StartNew: https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskfactory.startnew?view=net-6.0
 *  Task.Run : https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.run?view=net-6.0
 *  TaskStatus: https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskstatus?view=net-6.0
 */





// //==
// //Synchronously
// //==
//WriteLine("Running methods synchronously on one thread.\n");

//Helper.OutputThreadInfo();
//WriteLine("\n");

//Stopwatch timer = Stopwatch.StartNew();

//Helper.MethodA();
//Helper.MethodB();
//Helper.MethodC();

//WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");



//// ==
//// Asynchronously
//// ==
//WriteLine("Running methods asynchronously on multiple threads.");
//Helper.OutputThreadInfo();
//WriteLine("\n");

//Stopwatch timer = Stopwatch.StartNew();

//Task taskA = new (Helper.MethodA);
//taskA.Start();

//Task taskB = Task.Factory.StartNew(Helper.MethodB);
//Task taskC = Task.Run(Helper.MethodC);

//Task[] tasks = { taskA, taskB, taskC };

//// t.Wait, WaitAny(Task[]), WaitAll(Task[])
//Task.WaitAll(tasks);

//WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");


////== 
//// Passing values from one task to another
////==
//Helper.OutputThreadInfo();
//Stopwatch timer = Stopwatch.StartNew();

//WriteLine("Passing the result of one task as an input into another.\n");

Task<string> taskServiceThenSProc = Task.Factory
                                      .StartNew(Helper.CallWebService) // returns Task<decimal>
                                      .ContinueWith(previousTask =>     // returns Task<string>
                                            Helper.CallStoredProcedure(previousTask.Result)
                                       );


//WriteLine($"\nResult: {taskServiceThenSProc.Result}");

//WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");


//Task<decimal> taskValue = Task.Factory.StartNew(Helper.CallWebService);

//var result = await taskValue;

//decimal value = result;



//// Nested task
//Task outerTask = Task.Factory.StartNew(Helper.OuterMethod);

//outerTask.Wait();
//WriteLine("Console app is stopping.");

/*
  Wrapping task around other objects
    - Run as asynchronous but the result is not as task.
    - Moking asynchronous implementation during unit testing
 */
var task1 = "".IsValidXmlTag();
var task2 = "<xml>aa</xml>".IsValidXmlTag();
var task3 = ((string) null).IsValidXmlTag();

 





Console.ReadLine();