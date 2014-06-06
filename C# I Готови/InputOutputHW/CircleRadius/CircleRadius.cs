using System;

class CircleRadius
{
    static void Main()
    {
        double r;
        double Perimeter;
        Console.WriteLine("Enter the radius of the circle bellow:");
        r = double.Parse(Console.ReadLine());
        double CircleArea = 3.14 * (r * r);
        Perimeter = 2 * 3.14 * r;
        Console.WriteLine("The area of a circle with radius {0} is {1}.", r, CircleArea);
        Console.WriteLine("The perimeter of a circle with radius {0} is {1}.", r, Perimeter);
    }
}

