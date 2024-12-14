using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        string command = "";

        Console.WriteLine("Simple Stopwatch");
        Console.WriteLine("Press 'S' to start the stopwatch, 'T' to stop it, and 'E' to exit.");

        while (true)
        {
            Console.Write("Enter command: ");
            command = Console.ReadLine().ToUpper();

            if (command == "S")
            {
                stopwatch.Start();
                Console.WriteLine("Stopwatch started...");
            }
            else if (command == "T")
            {
                stopwatch.Stop();
                Console.WriteLine($"Stopwatch stopped. Elapsed time: {stopwatch.Elapsed.Seconds} seconds.");
            }
            else if (command == "E")
            {
                Console.WriteLine("Exiting stopwatch...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please press 'S' to start, 'T' to stop, or 'E' to exit.");
            }
        }
    }
}
