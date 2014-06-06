using System;

class CircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x and y to see if the point they make is within the circle K.");
        double CircleX = double.Parse(Console.ReadLine());
        double CircleY = double.Parse(Console.ReadLine());
        double RadiusK = 3;
        bool RectangleX = (-1 <= CircleX) && (CircleX <= 5);
        bool RectangleY = (-1 <= CircleY) && (CircleY <= 1);
        bool InsideTheRectangle = RectangleX && RectangleY;
        if ((CircleX * CircleX) + (CircleY * CircleY) <= RadiusK * RadiusK)
        {
            Console.WriteLine("The point that you have entered is within circle and ");
            if (InsideTheRectangle)
            {
                Console.WriteLine("within the rectangle.");
            }
            else
            {
                Console.WriteLine("outside the rectangle."); 
            }
        }
        else
        {
            Console.WriteLine("The point that you have entered is outside the circle and");
            if (InsideTheRectangle)
            {
                Console.WriteLine("within the rectangle.");
            }
            else
            {
                Console.WriteLine("outside the rectangle.");
            }
        }
    }
}
