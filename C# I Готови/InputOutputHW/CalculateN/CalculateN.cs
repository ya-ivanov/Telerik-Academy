using System;

class CalculateN
{
    static void Main()
    {
        uint Num1= 0, Num2= 0, Num3= 0, Num4= 0, Num5= 0;
        Num1 = uint.Parse(Console.ReadLine());
        Num2 = uint.Parse(Console.ReadLine());
        Num3 = uint.Parse(Console.ReadLine());
        Num4 = uint.Parse(Console.ReadLine());
        Num5 = uint.Parse(Console.ReadLine());
        uint SumOfAll = Num1 + Num2 + Num3 + Num4 + Num5;
        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", Num1, Num2, Num3, Num4, Num5, SumOfAll);
    }
}

