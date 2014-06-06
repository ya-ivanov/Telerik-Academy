using System;

class ReadNumberMethod
{
    static void ReadNumber(int start = 1, int end = 101)
    {
        int someNum = 0;

        for (int numTimes = 0; numTimes < 11; numTimes++)
        {
            Console.Write("Enter your {0} number: ", numTimes);
            try
            {
                someNum = int.Parse(Console.ReadLine());
                if (someNum > end || someNum < start)
                {
                    throw new ArgumentOutOfRangeException();
                }
                start = someNum;
            }
            catch (FormatException)
            {
                Console.WriteLine("The number must be an integer.\n");
                break;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The number must not be null.\n");
                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number should be inside the range <1...100>, \nand should be bigger than the number you have entered before.\n");
                break;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The entered number is too big or too small.");
                break;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter 10 numbers in the range <0...100>\nEvery number should be bigger than the number before.");
        ReadNumber(1, 100);
    }

}

