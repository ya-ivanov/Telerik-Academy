using System;

class OneToNumber
{
    static void Main()
    {
        byte one = 1;
        uint SomeNum = 0;
        Console.WriteLine("Enter Number Bellow:");
        SomeNum = uint.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        for (one = 1; one <= SomeNum; one++)
        {
            Console.WriteLine(one);
        }
    }
}

