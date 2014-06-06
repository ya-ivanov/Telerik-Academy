using System;

class TraillingZeros
{
    static void Main()
    {
        Console.Write("Enter N bellow:");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int multy = 1;
        int Times = 1;
        int FactN = 1;
        for (; Times < n + 1; )
        {
            FactN = FactN * Times;
            Times++;
        }
        Console.WriteLine("{0}! = {1}", n, FactN);
        while ((n / multy) > 0)
        {
            multy *= 5;
            counter += n / multy;
        }
        Console.WriteLine("Number of trailing zeros in {0}! ({1}) is {2}.", n,FactN, counter);
    }
}

