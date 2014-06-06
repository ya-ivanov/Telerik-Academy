using System;
using System.Collections.Generic;

class ReverseDigitsOfDecimal
{
    static void Reverse(decimal number)
    { 
        string SomeNumber = number.ToString();
        List<char> Container = new List<char>();
        foreach (char digit in SomeNumber)
        {
            Container.Add(digit);
        }
        Container.Reverse();
        Console.WriteLine("\nReversed:");
        foreach (char digit in Container)
        {
            Console.Write(digit);
        }
        Console.WriteLine("");
    }

    static void Main()
    {
        decimal SomeNum = 0M;
        Console.WriteLine("Write your number below:");
        SomeNum = decimal.Parse(Console.ReadLine());
        Reverse(SomeNum);
    }
}

