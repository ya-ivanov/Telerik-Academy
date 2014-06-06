using System;

class DigitName
{
    static void Main()
    {
        byte SomeNumber;
        Console.WriteLine("Enter a digit from 0 to 9.");
        SomeNumber = byte.Parse(Console.ReadLine());
        switch (SomeNumber)
        {
            case 1:
                Console.WriteLine("{0} in english is One.", SomeNumber); break;
            case 2:
                Console.WriteLine("{0} in english is Two.", SomeNumber); break;
            case 3:
                Console.WriteLine("{0} in english is three.", SomeNumber); break;
            case 4:
                Console.WriteLine("{0} in english is four.", SomeNumber); break;
            case 5:
                Console.WriteLine("{0} in english is five.", SomeNumber); break;
            case 6:
                Console.WriteLine("{0} in english is six.", SomeNumber); break;
            case 7:
                Console.WriteLine("{0} in english is seven.", SomeNumber); break;
            case 8:
                Console.WriteLine("{0} in english is eight.", SomeNumber); break;
            case 9:
                Console.WriteLine("{0} in english is nine.", SomeNumber); break;
            case 0:
                Console.WriteLine("{0} in english is zero/null.", SomeNumber); break;
            default:
                Console.WriteLine("Please choose digit from 0 to 9!"); break;
        }
    }
}

