using System.Collections;
namespace CollectionsConsoleApp;

// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-6.0
public static class StackDemo
{
    public static void CreateAStack()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");

        foreach (var item in myStack)
        {
            Console.WriteLine("{0}", item);
            Console.WriteLine();
        }

        var popValue = myStack.Pop();
        var peekValue = myStack.Peek();
    }


    public static void CreateAStackGeneric()
    {
        Stack<string> stack = new Stack<string>();
        // Fails
        // stack.Push(2);
    }

    
}


