// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // — First Order (domestic) —
        var homeAddr = new Address("789 Maple Ave", "Denver", "CO", "USA");
        var alice    = new Customer("Alice Johnson", homeAddr);
        var order1   = new Order(alice);
        order1.AddProduct(new Product("Bluetooth Speaker", "BS100", 45.50, 1));
        order1.AddProduct(new Product("Smart Watch",       "SW200",125.00, 2));

        // — Second Order (international) —
        var globalAddr = new Address("56 Cherry Lane", "Melbourne", "VIC", "Australia");
        var bob         = new Customer("Bob Chen", globalAddr);
        var order2      = new Order(bob);
        order2.AddProduct(new Product("Gaming Mouse",       "GM300", 39.99, 1));
        order2.AddProduct(new Product("Mechanical Keyboard","MK400", 89.99, 1));
        order2.AddProduct(new Product("HD Monitor Cable",   "HC500", 14.99, 2));

        var allOrders = new List<Order> { order1, order2 };

        foreach (var ord in allOrders)
        {
            Console.WriteLine("\n--- Packing Label ---");
            Console.WriteLine(ord.GetPackingLabel());

            Console.WriteLine("\n--- Shipping Label ---");
            Console.WriteLine(ord.GetShippingLabel());

            Console.WriteLine($"\nTotal Due: ${ord.GetTotalPrice():F2}\n");
        }
    }
}
