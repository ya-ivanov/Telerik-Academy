using System;

public class TimesInArray
{
    public static int SearchFor(int SomeNum, int[] Array)
    {
        int Times = 0;
        int index = 0;
        for (; index < Array.Length; index++)
        {
            if (Array[index] == SomeNum)
            {
                Times++;
            }
        }
        return Times;
    }
    static void Main()
    {
        int index = 0;
        int Times;
        int numberToSearchFor = 0;
        int SomeArrayElements = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] SomeArray = new int[SomeArrayElements];
        Console.WriteLine("Enter your array:");
        Console.Write("Element [{0}] = ", index);
        SomeArray[index] = int.Parse(Console.ReadLine());
        
        for (index = 1; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("What number do you want ro check for?");
        numberToSearchFor = int.Parse(Console.ReadLine());
        Times = SearchFor(numberToSearchFor, SomeArray);
        Console.WriteLine("Number {0} appears {1} times in the array.", numberToSearchFor, Times);
    }
}

