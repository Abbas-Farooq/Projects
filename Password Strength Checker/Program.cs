using System;
using System.Text.RegularExpressions;

class PasswordStrengthChecker
{
    static void Main()
    {
        Console.WriteLine("Password Strength Checker");
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        string passwordStrength = CheckPasswordStrength(password);
        Console.WriteLine("Password Strength: " + passwordStrength);
    }

    // Method to check the strength of a password
    static string CheckPasswordStrength(string password)
    {
        // Check if password meets the minimum length
        if (password.Length < 8)
        {
            return "Weak (Password must be at least 8 characters long)";
        }

        bool hasLower = false;
        bool hasUpper = false;
        bool hasDigit = false;
        bool hasSpecialChar = false;

        // Check for at least one lowercase letter, one uppercase letter, one digit, and one special character
        foreach (char c in password)
        {
            if (char.IsLower(c)) hasLower = true;
            if (char.IsUpper(c)) hasUpper = true;
            if (char.IsDigit(c)) hasDigit = true;
            if (char.IsPunctuation(c) || char.IsSymbol(c)) hasSpecialChar = true;
        }

        // Check the conditions for strength
        if (hasLower && hasUpper && hasDigit && hasSpecialChar)
        {
            return "Strong";
        }
        else if (hasLower && hasUpper && hasDigit)
        {
            return "Medium (Password should contain at least one special character)";
        }
        else
        {
            return "Weak (Password should contain at least one uppercase letter, one lowercase letter, one digit, and one special character)";
        }
    }
}
