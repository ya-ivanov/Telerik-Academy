using System;

class BinaryToDecimal
{
    static int GetDecRepresentation(int binNum)
    { 
        int output = 0;
        for (double i = 0; binNum > 0; i++)
        {
            if (binNum % 10 == 1)
            {
                output += (int)Math.Pow(2, i);
            }
            binNum /= 10;
        }
        return output;
    }

    static void Main()
    {
        Console.WriteLine("Enter your binary number below:");
        int binaryNum = int.Parse(Console.ReadLine());
        int result = GetDecRepresentation(binaryNum);
        Console.WriteLine("The decimal representation of your number is {0}.", result);

    }
}

