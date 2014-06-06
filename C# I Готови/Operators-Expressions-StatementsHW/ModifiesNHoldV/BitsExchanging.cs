using System;

class BitsExchanging
{
    static void Main()
    {
        Console.WriteLine("Enter your number bellow:");
        int myNbr = int.Parse(Console.ReadLine());
        int Mask1 = (7 << 3);
        int Mask2 = (7 << 24);
        int hold1 = (myNbr & Mask1);
        int hold2 = (myNbr & Mask2);
        hold1 = hold1 << 21;
        hold2 = hold2 >> 21;
        myNbr = myNbr & (~Mask1) & (~Mask2);
        Console.WriteLine("This is your new number after bits exchanging: {0}", myNbr + hold1 + hold2);
    }
}

