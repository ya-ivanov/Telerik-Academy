using System;

class GCDofTwoIntegers
{
    static int GCD(int a, int b)
    {
        int Remainder;
        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        return a;
    }
    static void Main()
    {
        int Nbr1, Nbr2;
        Console.WriteLine("Enter two integers bellow: ");
        Nbr1 = int.Parse(Console.ReadLine());
        Nbr2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The GCD of {0} and {1} is {2}.", Nbr1, Nbr2, GCD(Nbr1, Nbr2));
    }
}

