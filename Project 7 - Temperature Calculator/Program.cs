using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Temperature Converter");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");
        Console.Write("Pick 1 or 2: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Write your temperature");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");
        }

        else if (choice == 2) 
        {
            Console.WriteLine("Write your temperature");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }

        else
        {
            Console.WriteLine("Invalid Choice");
        }        
            
        
    }
}
