// See https://aka.ms/new-console-template for more information
using MainConsole;
using System.Numerics;
using System.Threading;

Console.WriteLine("Hello, welcome to storage!");

Storage storage = new Storage();
Product product1 = new Product
{
    id = 1,
    name = "Bedside Table",
    size = 5,
    quantity = 30
};

Product product2 = new Product
{
    id = 2,
    name = "Lamp",
    size = 2,
    quantity = 22
};

Product product3 = new Product
{
    id = 3,
    name = "Laptop",
    size = 3,
    quantity = 5
};

Product product4 = new Product
{
    id = 4,
    name = "iPhone",
    size = 1,
    quantity = 10
};
storage.addProduct(product1);
storage.addProduct(product2);
storage.addProduct(product3);
storage.addProduct(product4);
Console.WriteLine("Storage Status:");
storage.checkStorage();
Console.WriteLine();
Console.WriteLine("Listing all products in storage:");
storage.listAllProducts();
Console.WriteLine();
Console.WriteLine("Removing the Laptop from storage...");
storage.removeProduct(product3);
Console.WriteLine();
Console.WriteLine("Storage Status after removal:");
storage.checkStorage();
Console.WriteLine();
Console.WriteLine("Listing all products in storage after removal:");
storage.listAllProducts();
