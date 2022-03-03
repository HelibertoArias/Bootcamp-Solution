
int counter = 0; 

Console.WriteLine("Started");
Console.WriteLine();

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
CancellationToken cancellationToken = cancellationTokenSource.Token;

cancellationToken.Register(() => Console.WriteLine("\nProcess canceled"));

Task task = Task.Run(() =>
{
    while (!cancellationToken.IsCancellationRequested)
    {
        counter++;

        Console.Write($"{counter}|");
        Thread.Sleep(500);
    }
}, cancellationToken);

Console.WriteLine("Press enter to stop the task");
Console.ReadLine();

cancellationTokenSource.Cancel();
Console.WriteLine($"Task executed {counter} times");

Console.WriteLine();
Console.WriteLine("Press any key to close");
Console.ReadKey();