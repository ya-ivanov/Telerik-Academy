using System;

class CalculateRectangleArea
{
    static void Main(string[] args)
    {
        double height;
        Console.WriteLine("Enter the Rectangle's height.");
        height = double.Parse(Console.ReadLine());
        double width;
        Console.WriteLine("Enter the Rectangle's widht.");
        width = double.Parse(Console.ReadLine());
        double RectArea = height * width;
        Console.WriteLine("The area of the Rectangle is {0}.", RectArea);
    }
}

