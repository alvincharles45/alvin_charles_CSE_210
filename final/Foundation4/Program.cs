// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sessions = new List<Activity>
        {
            new Running("07/01/2025", 25, 5.0),
            new Cycling("07/02/2025", 40, 22.5),
            new Swimming("07/03/2025", 30, 20)
        };

        foreach (var session in sessions)
        {
            Console.WriteLine(session.GetSummary());
        }
    }
}
