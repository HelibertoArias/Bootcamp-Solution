using Newtonsoft.Json;

namespace TaskWebServicesConsoleApp;

public class ServiceApiHelper
{

    public async Task Run(Dictionary<string, string> urlDictionary, CancellationToken cancellationToken)
    {

        Dictionary<string, Task<IEnumerable<StockPrice>>> requestTasks = new();

        foreach (var item in urlDictionary)
        {
            requestTasks.Add(item.Key, GetStocksAsync(cancellationToken, item.Value));
        }

        try
        {
            await Task.WhenAll(requestTasks.Values);
            var dataResult = requestTasks.ToDictionary(x => x.Key, x => x.Value.Result);
            Print(dataResult);
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine($"\n{nameof(OperationCanceledException)} thrown\n");
        }



    }

    public async Task<IEnumerable<StockPrice>> GetStocksAsync(CancellationToken cancellationToken, string url)
    {
        var index = url.LastIndexOf("/") + 1;
        Console.WriteLine($"Starting {url.Substring(index)}");

        await Task.Delay(new Random().Next(2, 10) * 1000);

        using (var client = new HttpClient())
        {
            var responseTask = client.GetAsync(url, cancellationToken);

            var response = await responseTask;

            var content = await response.Content.ReadAsStringAsync();


            Console.WriteLine($"Ending {url.Substring(index)}");

            return !string.IsNullOrWhiteSpace(content) ? JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(content) : new List<StockPrice>();
        }
    }


    public void Print(Dictionary<string, IEnumerable<StockPrice>> dataResult)
    {
        Console.WriteLine("\n\n");
        foreach (var item in dataResult)
        {
            switch (item.Key)
            {
                case "MSFT":
                    Console.WriteLine($"{item.Key} Max change is {item.Value.Max(x => x.Change)}");
                    break;
                case "Googl":
                    Console.WriteLine($"{item.Key} Min change Percent is {item.Value.Min(x => x.ChangePercent)}");
                    break;
                case "Voya":
                    Console.WriteLine($"{item.Key} Average volume is {item.Value.Average(x => x.Volume)}");
                    break;
                case "Hbi":
                    Console.WriteLine($"{item.Key} Count records is {item.Value.Count()}");
                    break;
                case "Foxf":
                    Console.WriteLine($"{item.Key} Min change is {item.Value.Min(x => x.Change)}");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

    }


}

