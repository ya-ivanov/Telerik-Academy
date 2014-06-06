using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter your number below:");
        double result = 0;
        try
        {
            int someNum = int.Parse(Console.ReadLine());
            if (someNum < 0)
            {
                throw new FormatException();
            }
            result = Math.Sqrt(someNum);
            Console.WriteLine("Sqrt of {0} = {1}", someNum, result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid Number!");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}

