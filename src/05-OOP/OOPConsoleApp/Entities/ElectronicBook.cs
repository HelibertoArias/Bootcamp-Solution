using OOPConsoleApp.Entities.Interfaces;

namespace OOPConsoleApp.Entities;

public class ElectronicBook : IProduct, IOnlineProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Type { get; set; }
    public int DownloadSize { get; set; }
}

