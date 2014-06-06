﻿using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Your decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        int remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary representation:  {0}", result);
    }
}

