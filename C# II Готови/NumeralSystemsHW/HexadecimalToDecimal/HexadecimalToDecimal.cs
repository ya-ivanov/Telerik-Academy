using System;

class HexadecimalToDecimal
{
    static long HexToDecimal(string number)
    {
        string Digits = "0123456789ABCDEF";
        if (number == "")
        {
            Console.WriteLine("Please enter a valid hexadecimal number.");
            return 0;
        }
        number = number.ToUpperInvariant();
        long result = 0;
        long multiplier = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char c = number[i];
            int digit = Digits.IndexOf(c);
            result += digit * multiplier;
            multiplier *= 16;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter your hexadecimal number below:");
        string hexNum = Console.ReadLine();
        long result = 0;
        result = HexToDecimal(hexNum);
        Console.WriteLine("The decimal representation of your number is {0}.", result);
    }
}

