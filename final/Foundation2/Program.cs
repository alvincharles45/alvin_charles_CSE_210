// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First order (Domestic customer)
        var addrOne    = new Address("789 Maple Ave",    "Denver",    "CO",        "USA");
        var clientOne  = new Customer("Alex Turner",      addrOne);
        var orderAlpha = new Order(clientOne);
        orderAlpha.AddProduct(new Product("Bluetooth Speaker",    "BS100",  45.50, 1));
        orderAlpha.AddProduct(new Product("Smart Watch",          "SW200", 125.00, 2));

        // Second order (International customer)
        var addrTwo   = new Address("56 Cherry Lane",     "Melbourne", "VIC",       "Australia");
        var clientTwo = new Customer("Bella Rossi",        addrTwo);
        var orderBeta = new Order(clientTwo);
        orderBeta.AddProduct(new Product("Gaming Mouse",           "GM300", 39.99, 1));
        orderBeta.AddProduct(new Product("Mechanical Keyboard",    "MK400", 89.99, 1));
        orderBeta.AddProduct(new Product("HD Monitor Cable",       "HC500", 14.99, 2));

        // Display both orders
        var orders = new List<Order> { orderAlpha, orderBeta };

        foreach (var ord in orders)
        {
            Console.WriteLine("\n--- Packing Label ---");
            Console.WriteLine(ord.GetPackingLabel());

            Console.WriteLine("\n--- Shipping Label ---");
            Console.WriteLine(ord.GetShippingLabel());

            Console.WriteLine($"\nTotal Due: ${ord.GetTotalPrice():F2}\n");
        }
    }
}
