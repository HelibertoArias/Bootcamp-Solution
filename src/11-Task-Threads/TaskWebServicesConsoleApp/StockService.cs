using Newtonsoft.Json;

namespace TaskWebServicesConsoleApp;

public class StockService
{

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
}

