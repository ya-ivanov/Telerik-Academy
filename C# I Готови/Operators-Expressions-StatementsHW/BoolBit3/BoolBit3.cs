using System;

class BoolBit3
{
    static void Main()
    {
        Console.WriteLine("Enter your number bellow:");
        int SomeNbr = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int ThirdBit = (SomeNbr & mask) >> 3;
        Console.WriteLine("The third bit is {0}",ThirdBit);
    }
}

