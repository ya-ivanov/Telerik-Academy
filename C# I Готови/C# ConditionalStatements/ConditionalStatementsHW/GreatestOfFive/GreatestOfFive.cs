using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers bellow:");
        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int Num3 = int.Parse(Console.ReadLine());
        int Num4 = int.Parse(Console.ReadLine());
        int Num5 = int.Parse(Console.ReadLine());
        int FirstTwo = (Math.Max(Num1, Num2));
        int SecondTwo = (Math.Max(Num3, Num4));
        int ThirdTwo = (Math.Max(FirstTwo, SecondTwo));
        int Biggest = (Math.Max(ThirdTwo, Num5));
        Console.Clear();
        Console.WriteLine("The Greatest number is {0}.", Biggest);
    }
}

