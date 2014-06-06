using System;

class MinimalAndMaximal
{
    static void Main()
    {
        int Number = 0;
        int MaxN = 0;
        int MinN = 0;
        Console.WriteLine("How many number do you want to compare?");
        int Nbrs = int.Parse(Console.ReadLine());
        Console.WriteLine("______________________________");
        int Times = 1;

        for (; Times < Nbrs + 1; )
        {
            Console.WriteLine("Enter your {0} number", Times);
            if (Times == 1)
            {
                Number = int.Parse(Console.ReadLine());
                MaxN = Number;
                MinN = Number;
                Times++;
            }
            else
            {
                Number = int.Parse(Console.ReadLine());
                if (Number > MaxN)
                {
                    MaxN = Number;
                }
                if (Number < MinN)
                {
                    MinN = Number;
                }
                Times++;
            }
        }
        Console.WriteLine("______________________________");
        Console.WriteLine("Minimal- {0}", MinN);
        Console.WriteLine("Maximal- {0}", MaxN);
    }
}

