using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x and y to see if the point they make is within the circle K.");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int RadiusK = 5;
        if ((x * x) + (y * y) <= RadiusK * RadiusK)
        {
            Console.WriteLine("The point that you have entered is within circle K.");
        }
        else
        {
            Console.WriteLine("The point that you have entered is not in within circle K.");
        }
    }
}

