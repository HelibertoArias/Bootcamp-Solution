// <copyright file="All.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Rocco.Logic;

public interface IPLCLoggerProvider
{
    List<Row> GetData();
}

public class Row
{
    public DateTime Time { get; set; }
    public string Text { get; set; }
}

public class NewPLCLogger : IPLCLoggerProvider
{
    public List<Row> GetData()
    {
        // conect to a PLC, get information
        return new List<Row>();
    }
}

class Main
{
    IPLCLoggerProvider p1 = new NewPLCLogger();
    IPLCLoggerProvider p2 = new OldPCLLoggerAdapter(new OldPCLLogger());
}


public class OldPCLLogger
{
    public List<Row> GetLog()
    {
        // connect to a OLD PLC, get information
        return new List<Row>();
    }
}

public class OldPCLLoggerAdapter : IPLCLoggerProvider
{
    private readonly OldPCLLogger oldLogger;

    public OldPCLLoggerAdapter(OldPCLLogger oldLogger)
    {
        this.oldLogger = oldLogger;
    }

    public List<Row> GetData()
    {
        return oldLogger.GetLog();
    }
}


