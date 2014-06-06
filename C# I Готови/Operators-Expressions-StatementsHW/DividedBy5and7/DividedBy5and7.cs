using System;

class DividedBy5and7
{
    static void Main()
    {
        int SomeNumber;
        Console.WriteLine("Enter a number bellow:");
        SomeNumber = int.Parse(Console.ReadLine());
        bool by5and7 = SomeNumber % 5 == 0 && SomeNumber % 7 == 0;
        if (by5and7)
        {
            Console.WriteLine("The number divides by 5 and 7.");
        }
        else
        {
            Console.WriteLine("The number can't be divided by 5 and 7 without reminder.");
        }
    }
}

