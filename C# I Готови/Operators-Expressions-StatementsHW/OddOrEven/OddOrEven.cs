using System;

class OddOrEven
{
    static void Main()
    {
        int Num;
        Console.WriteLine("Enter a number to see if it is odd or even.");
        Num = int.Parse(Console.ReadLine());
        if (Num % 2 == 0)
        {
            Console.WriteLine("\nThe number {0} is even\n", Num);
        }
        else
        {
            Console.WriteLine("\nThe number {0} is odd\n", Num);
        }

    }
}

