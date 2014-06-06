using System;
using System.Globalization;

class DaysBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter your first date: example<21.11.2013>");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        double between = (end-start).TotalDays;
        Console.WriteLine("DaysBetween: {0}", between);
    }
}

