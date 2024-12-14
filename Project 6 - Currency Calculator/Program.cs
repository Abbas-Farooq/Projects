using System;

class CurrencyConverter
{
    static double USD_TO_EUR = 0.92;
    static double USD_TO_JPY = 134.55;
    static double USD_TO_GBP = 0.82;
    static double USD_TO_INR = 83.50;

    static double EUR_TO_USD = 1 / USD_TO_EUR;
    static double JPY_TO_USD = 1 / USD_TO_JPY;
    static double GBP_TO_USD = 1 / USD_TO_GBP;
    static double INR_TO_USD = 1 / USD_TO_INR;

    static void Main(string[] args)
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("Select a source currency:");
        Console.WriteLine("1. USD - US Dollar");
        Console.WriteLine("2. EUR - Euro");
        Console.WriteLine("3. JPY - Japanese Yen");
        Console.WriteLine("4. GBP - British Pound");
        Console.WriteLine("5. INR - Indian Rupee");

        Console.Write("Enter your choice (1-5): ");
        int sourceCurrencyChoice = int.Parse(Console.ReadLine());

        Console.Write("Enter the amount you want to convert: ");
        double amount = double.Parse(Console.ReadLine());

        Console.WriteLine("Select a target currency:");
        Console.WriteLine("1. USD - US Dollar");
        Console.WriteLine("2. EUR - Euro");
        Console.WriteLine("3. JPY - Japanese Yen");
        Console.WriteLine("4. GBP - British Pound");
        Console.WriteLine("5. INR - Indian Rupee");

        Console.Write("Enter your choice (1-5): ");
        int targetCurrencyChoice = int.Parse(Console.ReadLine());

        double convertedAmount = ConvertCurrency(sourceCurrencyChoice, targetCurrencyChoice, amount);

        if (convertedAmount != -1)
        {
            Console.WriteLine($"Converted Amount: {convertedAmount:F2}");
        }
        else
        {
            Console.WriteLine("Invalid currency selection.");
        }
    }

    static double ConvertCurrency(int source, int target, double amount)
    {
        double result = -1;
        double amountInUSD = 0;

        switch (source)
        {
            case 1:
                amountInUSD = amount;
                break;
            case 2:
                amountInUSD = amount * EUR_TO_USD;
                break;
            case 3:
                amountInUSD = amount * JPY_TO_USD;
                break;
            case 4:
                amountInUSD = amount * GBP_TO_USD;
                break;
            case 5:
                amountInUSD = amount * INR_TO_USD;
                break;
            default:
                return -1;
        }

        switch (target)
        {
            case 1:
                result = amountInUSD;
                break;
            case 2:
                result = amountInUSD * USD_TO_EUR;
                break;
            case 3:
                result = amountInUSD * USD_TO_JPY;
                break;
            case 4:
                result = amountInUSD * USD_TO_GBP;
                break;
            case 5:
                result = amountInUSD * USD_TO_INR;
                break;
            default:
                return -1;
        }

        return result;
    }
}
