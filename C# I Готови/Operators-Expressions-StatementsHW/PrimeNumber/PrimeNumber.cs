using System;

class PrimeNumber
{
    static void Main()
    {
        int myNbr;
        myNbr = int.Parse(Console.ReadLine());
        int TimeDivides = 0;
        int dividers = 1;
        for (; dividers < 100; )
        {
            if (myNbr % dividers == 0)
            {
                TimeDivides++;
            }
            dividers++;
        }
        if (TimeDivides > 2)
        {
            Console.WriteLine("The number {0} is not prime number.", myNbr);
        }
        else 
        {
            Console.WriteLine("The number {0} is prime number.", myNbr);
        }
    }
}

