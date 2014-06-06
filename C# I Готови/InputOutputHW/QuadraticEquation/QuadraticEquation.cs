using System;

class QuadraticEquation
{
    static void Main()
    {

        double a, b, c, x1, x2;
        Console.WriteLine("Enter a bellow:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b bellow:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c bellow:");
        c = double.Parse(Console.ReadLine());
        double Discriminant = (b * b) - 4 * a * c;
        Console.WriteLine("The discriminant is: {0}", Discriminant);
        if (Discriminant < 0)
        {
            Console.WriteLine("There is no solution to this equation, because the discriminant is bellow 0.");
        }
        else if (Discriminant == 0)
        {
            Console.WriteLine("There is one real root.");
        }
        else if (Discriminant > 0)
        {
            Console.WriteLine("There are two real roots.");
        }
        double sqrt = Math.Sqrt(Discriminant);
        x1 = (-b + sqrt) / (2 * a);
        
        x2 = (-b - sqrt) / (2 * a);
        Console.WriteLine("x1 = {0}", x1);
        Console.WriteLine("x2 = {0}", x2);

    }

}

