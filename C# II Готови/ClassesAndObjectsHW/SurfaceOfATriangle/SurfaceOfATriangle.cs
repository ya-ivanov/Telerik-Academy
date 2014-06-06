using System;

class SurfaceOfATriangle
{
    static double SideAndAttitude(double A, double ha)
    {
        return (A * ha) / 2;
    }

    static double ThreeSides(double A, double B, double C)
    {
        double P = ((A + B + C) / 2);
        return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
    
    static void Main()
    {
        double result = 0; 
        int answer = 0;
        Console.WriteLine("What method do you want to use? Calculate by:");
        Console.WriteLine("\n1-Side and Attitude to it\n2-Three sides");
        answer = int.Parse(Console.ReadLine());
        if(answer == 1)
        {
            Console.WriteLine("Enter A below:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ha below:");
            double ha = double.Parse(Console.ReadLine());
            result = SideAndAttitude(A, ha);
        }
        else if (answer == 2)
        {
            Console.WriteLine("Enter A below:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B below:");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter C below:");
            double C = double.Parse(Console.ReadLine());
            result = ThreeSides(A, B, C);
        }
        
        else 
        {
            Console.WriteLine("Please choose from 1 or 2.");
        }
        Console.WriteLine("The surface is {0}.", result);
        

    }
}

