using System;

class DivisibleBy3And7
{
    static void Main()
    {
        int n = 0;
        int Nbr = 0;
        Console.WriteLine("Enter yoyr number bellow:");
        Nbr = int.Parse(Console.ReadLine());
        for (; n < Nbr + 1; )
        {
            if (n % 3 == 0 && n % 7 == 0)
            {

            }
            else
            {
                Console.Write(n + ", ");
            }
            n++;
        }
    }
}

