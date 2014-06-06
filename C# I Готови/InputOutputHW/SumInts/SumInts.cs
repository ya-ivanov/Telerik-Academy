using System;

class SumInts
{
    static void Main()
    {
        int Nbr1, Nbr2, Nbr3, NbrSum;
        Console.WriteLine("Enter the first number bellow:");
        Nbr1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number bellow:");
        Nbr2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number bellow:");
        Nbr3 = int.Parse(Console.ReadLine());
        NbrSum = Nbr1 + Nbr2 + Nbr3;
        Console.WriteLine("{0} + {1} = {2}", Nbr1, Nbr2, NbrSum);
    }
}

