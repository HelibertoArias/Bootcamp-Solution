using System.Reflection;

namespace TradeProcessorConsoleApp.Version02;
internal class Manager_V2
{
    public static void Run()
    {
        System.Console.WriteLine("Running Manager_v2");

        string path = Directory.GetFiles(Directory.GetCurrentDirectory()).FirstOrDefault(x => x.EndsWith("trades.txt"));


        var tradeStream = File.OpenRead(path);

        var tradeProcessor = new TradeProcessor();
        tradeProcessor.ProcessTrades(tradeStream);
    }
}
