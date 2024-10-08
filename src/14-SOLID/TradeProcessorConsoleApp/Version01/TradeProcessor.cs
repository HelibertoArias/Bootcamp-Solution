﻿namespace TradeProcessorConsoleApp.Version01;
public class TradeProcessor
{
    // Stream class https://docs.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-6.0
    // Some of the more commonly used streams that inherit from Stream are FileStream, and MemoryStream.
    public void ProcessTrades(Stream stream)
    {
        // ReadTradeData
        var lines = new List<string>();
        using (var reader = new StreamReader(stream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        // ParseTrades
        var trades = new List<TradeRecord>();

        var lineCount = 1;
        foreach (var line in lines)
        {
            var fields = line.Split(new char[] { ',' });

            if (fields.Length != 3)
            {
                // LogMessage
                Console.WriteLine("WARN: Line {0} malformed. Only {1} field(s) found.", lineCount, fields.Length);
                continue;
            }

            if (fields[0].Length != 6)
            {
                // LogMessage
                Console.WriteLine("WARN: Trade currencies on line {0} malformed: '{1}'", lineCount, fields[0]);
                continue;
            }

            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                // LogMessage
                Console.WriteLine("WARN: Trade amount on line {0} not a valid integer: '{1}'", lineCount, fields[1]);
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                // LogMessage
                Console.WriteLine("WARN: Trade price on line {0} not a valid decimal: '{1}'", lineCount, fields[2]);
            }

            // MapTradeDataToTradeRecord
            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);


            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };

            trades.Add(trade);

            lineCount++;
        }

        // StoreTrades
        using (var connection = new System.Data.SqlClient.SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=TradeDatabase;Integrated Security=True;"))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                foreach (var trade in trades)
                {
                    var command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.insert_trade";
                    command.Parameters.AddWithValue("@sourceCurrency", trade.SourceCurrency);
                    command.Parameters.AddWithValue("@destinationCurrency", trade.DestinationCurrency);
                    command.Parameters.AddWithValue("@lots", trade.Lots);
                    command.Parameters.AddWithValue("@price", trade.Price);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            connection.Close();
        }

        //LogMessage
        Console.WriteLine("INFO: {0} trades processed", trades.Count);
    }

    private static float LotSize = 100000f;

}