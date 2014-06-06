using System;

class IsLeap
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the year {0} leap: {1}",year, DateTime.IsLeapYear(year));
    }
}

