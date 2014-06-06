using System;

class BetweenTwoIntegers
{
    static void Main()
    {
        int p = 5;
        uint FirstNbr;
        uint SecondNbr;
        FirstNbr = uint.Parse(Console.ReadLine());
        SecondNbr = uint.Parse(Console.ReadLine());
        int timesFits = 0;
        do
        {
            if (FirstNbr % p == 0)
            {
                timesFits = timesFits + 1;
            }
            FirstNbr = FirstNbr + 1;
        } while (FirstNbr <= SecondNbr);
        Console.WriteLine("Five fits {0} times.", timesFits);
    }
}
