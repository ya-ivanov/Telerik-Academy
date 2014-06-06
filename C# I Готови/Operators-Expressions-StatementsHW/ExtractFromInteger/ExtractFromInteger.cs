using System;

class ExtractFromInteger
{
    static void Main()
    {
        Console.Write("Enter your number bellow: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("What is the position of the bit that you like to check: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        if ((i & mask) != 0)
        {
            Console.WriteLine("In {0} the {1} bit is {2}", i, b, 1);
        }
        else
        {
            Console.WriteLine("In {0} the {1} bit is {2}.", i, b, 0);
        }
     }
}

