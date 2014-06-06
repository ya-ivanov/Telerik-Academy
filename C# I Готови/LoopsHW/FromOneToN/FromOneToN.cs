using System;

class FromOneToN
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter your number bellow:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("____________");
        int Nbr = 1;
        for (;Nbr < n+1;)
        {
            Console.WriteLine(Nbr);
            Nbr++;
        }
    }
}

