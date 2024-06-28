// See https://aka.ms/new-console-template for more information
using CountPriceLibrary;


Console.WriteLine("Hello, World!");

IMaterial material = new Oak();
IShape shape = new Round(0.55);
IProduct product = new Table(material, shape);
Console.WriteLine(product.Price);