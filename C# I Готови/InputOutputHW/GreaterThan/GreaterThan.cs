using System;

class GreaterThan
{
    static void Main()
    {
        Console.WriteLine("Enter the first number bellow:");
        decimal Num1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first number bellow:");
        decimal Num2 = decimal.Parse(Console.ReadLine());
        bool equals;
        equals = Num1 > Num2;
        Console.Clear();
        switch (equals)
        {
            case true:
                Console.WriteLine("{0} is greater than {1}.", Num1, Num2);
                break;
            case false:
                Console.WriteLine("{0} is not greater than {1}.", Num1, Num2);
                Console.WriteLine("{1} is greater than {0}.", Num1, Num2);
                break;
        }
    }
}

