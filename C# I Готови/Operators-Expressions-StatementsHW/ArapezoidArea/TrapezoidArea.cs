using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter a, b and h (each one on a new line), to find the area of a trapezoid.");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area is {0}", area);
    }
}

