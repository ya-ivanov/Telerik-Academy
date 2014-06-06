using System;
using System.Globalization;

    class AfterSixHoursAndThirtyMinutes
    {
        static void Main()
        {
            Console.WriteLine("Enter your first date: example<21.11.2013 12:30:30>");
            DateTime yourDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            yourDate = yourDate.AddHours(6.5);
            string after = yourDate.ToString("dddd", new CultureInfo("bg-BG"));
            after += " ";
            after += yourDate.ToString("d.M.yyyy hh:mm:ss", new CultureInfo("bg-BG"));
            Console.WriteLine(after);
        }
    }

