using Singleton;
using static System.Console;

WriteLine("Singleton");

//var p1 = new PDFConverter();
//WriteLine(p1.GetSessionInfo());

//var p2 = new PDFConverter();
//WriteLine(p2.GetSessionInfo());


PDFConverter p1 = PDFConverter.GetInstance;
WriteLine(p1.GetSessionInfo());

PDFConverter p2 = PDFConverter.GetInstance;
WriteLine(p2.GetSessionInfo());


Console.ReadLine();