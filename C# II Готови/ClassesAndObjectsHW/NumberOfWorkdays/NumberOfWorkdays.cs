using System;

class NumberOfWorkdays
{
    static void Main()
    {
        DateTime[] holiday = 
        {
            (new DateTime(2013, 02, 04)),
            (new DateTime(2013, 02, 05)),
            (new DateTime(2013, 02, 07)),
            (new DateTime(2013, 02, 14)),
            (new DateTime(2013, 03, 01)),
            (new DateTime(2013, 03, 03)),
            (new DateTime(2013, 03, 17)),
        };

        DateTime Today = DateTime.Today;
        Console.Write("Enter End date below [year-month-day]:\n");
        DateTime End = DateTime.Parse(Console.ReadLine());
        CountDays(Today, End, holiday);
    }

    private static void CountDays(DateTime today, DateTime end, DateTime[] holidays)
    {
        int lengthDays = (end - today).Days;
        int lengthDays2 = (end - today).Days;
        DateTime curntDate = new DateTime();
        for (int i = 0; i <= lengthDays2; i++)
        {
            curntDate = today.AddDays(i);
            for (int days = 0; days < holidays.Length; days++)
            {
                int compareDates = curntDate.CompareTo(holidays[days]);
                if (compareDates == 0)
                {
                    lengthDays--;
                }
            }
            if (curntDate.DayOfWeek == DayOfWeek.Saturday || curntDate.DayOfWeek == DayOfWeek.Sunday)
            {
                lengthDays--;
            }
        }
        PrintResult(today, end, lengthDays);

    }
    private static void PrintResult(DateTime today, DateTime end, int lengthDays)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Today: {0}", today);
        Console.WriteLine("End Date: {0}", end);
        Console.WriteLine("There are {0} working days.", lengthDays);
        Console.WriteLine("-----------------------------------------------");
    }
}

