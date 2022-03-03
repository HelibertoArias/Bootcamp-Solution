using TaskWebServicesConsoleApp;
using static System.Console;

string[] parameters = new[] { "MSFT", "Googl", "Voya", "Hbi", "Foxf" };

Dictionary<string, string> urlDictionary = parameters.Select(parameter => new
{
    key = parameter,
    value = $"https://ps-async.fekberg.com/api/stocks/{parameter}"
}).ToDictionary(x => x.key, x => x.value);


WriteLine("Hit Enter to cancel");

CancellationTokenSource? cancellationTokenSource = new CancellationTokenSource();
CancellationToken cancellationToken = cancellationTokenSource.Token;
cancellationToken.Register(() => Console.WriteLine($"\nProcess canceled"));


var helper = new ServiceApiHelper();
// dont use await here becacuse you won't be able to cancel this operation.
helper.Run(urlDictionary, cancellationToken);


ReadLine();

cancellationTokenSource.Cancel();
cancellationTokenSource = null;

ReadLine();


