using System;

class BitPositionValue1
{
    static void Main()
    {
        Console.Write("Enter your number bellow: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("What is the position of the bit that you like to check: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if ((mask & v) != 0)
        {
            Console.WriteLine("True. It is 1.");
        }
        else
        {
            Console.WriteLine("False. It is 0.");
        }
    }
}

