using System;

class ExchangeValues
{
    static void Main()
    {
        int Num1;
        int Num2;
        int ExNumber;
        Num1 = int.Parse(Console.ReadLine());
        Num2 = int.Parse(Console.ReadLine());
        if (Num1 > Num2)
        {
            ExNumber = Num1;
            Num1 = Num2;
            Num2 = ExNumber;
            Console.WriteLine("Values exchanged. {0}, {1}", Num1, Num2);
        }
        else
        {
            Console.WriteLine("The second number is bigger than the first one. Nothing is exchanged.");
        }
    }
}

