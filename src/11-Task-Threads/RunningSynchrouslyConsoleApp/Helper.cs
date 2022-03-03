using static System.Console;

namespace RunningSynchrouslyConsoleApp
{
    public static class Helper
    {
        public static void OutputThreadInfo()
        {
            Thread t = Thread.CurrentThread;

            WriteLine(
              "Thread Id: {0}, Priority: {1}, Background: {2}, Name: {3}",
              t.ManagedThreadId,
              t.Priority,
              t.IsBackground,
              //  ?? null-coalescing operator 
              //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator// 
              t.Name ?? "null");
        }


        #region Thread

        public static void MethodA()
        {
            WriteLine("Starting Method A...");
            OutputThreadInfo();
            Thread.Sleep(3000); // simulate three seconds of work 
            WriteLine("Finished Method A.\n");
        }

        public static void MethodB()
        {
            WriteLine("Starting Method B...");
            OutputThreadInfo();
            Thread.Sleep(2000); // simulate two seconds of work 
            WriteLine("Finished Method B.\n");
        }

        public static void MethodC()
        {
            WriteLine("Starting Method C...");
            OutputThreadInfo();
            Thread.Sleep(1000); // simulate one second of work 
            WriteLine("Finished Method C.\n");
        } 
        #endregion


        #region Task continued
        public static decimal CallWebService()
        {
            WriteLine("Starting call to web service...");
            OutputThreadInfo();
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to web service.\n");
            return 89.99M;
        }

        public static string CallStoredProcedure(decimal amount)
        {
          
            WriteLine("\nStarting call to stored procedure...");
            OutputThreadInfo();
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to stored procedure.");
            return $"12 products cost more than {amount:C}.";
        }


        #endregion



        #region Nested tasks
        public static void OuterMethod()
        {
            WriteLine("Outer method starting...");

            Task innerTask = Task.Factory.StartNew(InnerMethod, TaskCreationOptions.AttachedToParent );
            WriteLine("Outer method finished.");
        }

        public static void InnerMethod()
        {
            WriteLine("Inner method starting...");
            Thread.Sleep(2000);
            WriteLine("Inner method finished.");
        } 
        #endregion


    }
}
