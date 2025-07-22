// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var venueA      = new Address("47 Oakside Drive",  "Portland", "OR",     "USA");
        var moonlight   = new Lecture("Moonlight Sonata Lecture",
                                       "Analyzing Beethoven's masterpiece",
                                       "Sep 15", "7:30 PM", venueA,
                                       "Dr. Harmonia", 150);

        var venueB      = new Address("12 King's Highway",  "London",   "",      "UK");
        var galleryGala = new Reception("Renaissance Art Gala",
                                        "An evening with artists",
                                        "Oct 05", "5:00 PM", venueB,
                                        "gallery@renaissance.uk");

        var venueC      = new Address("250 Beach Road",      "Sydney",   "NSW",   "Australia");
        var forestYoga  = new OutdoorGathering("Forest Yoga Retreat",
                                               "Sunrise stretch in the woods",
                                               "Nov 10", "8:00 AM", venueC,
                                               "Clear, 55°F");

        var schedule    = new List<Event> { moonlight, galleryGala, forestYoga };

        foreach (var e in schedule)
        {
            Console.WriteLine("BASIC INFO:");
            Console.WriteLine(e.ShowBasicInfo());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\nBRIEF INFO:");
            Console.WriteLine(e.GetBriefInfo());

            Console.WriteLine("\n-----------------------------\n");
        }
    }
}
