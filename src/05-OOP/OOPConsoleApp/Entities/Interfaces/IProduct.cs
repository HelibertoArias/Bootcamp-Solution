namespace OOPConsoleApp.Entities.Interfaces;

// products: Online && Physical
//public interface IProduct
//{
//    int Id { get; set; }

//    string Name { get; set; }

//    decimal Price { get; set; }

//    // Physical product
//    int HeightDimension { get; set; }

//    // Physical product
//    int WidthDimension { get; set; }

//    int Type { get; set; }

//    // Online product
//    int DownloadSize { get; set; }

//}




public interface IProduct
{
    int Id { get; set; }

    string Name { get; set; }

    decimal Price { get; set; }

    int Type { get; set; }

}
