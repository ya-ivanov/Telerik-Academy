using System;

class BiggerThanNeighbors
{
    static void IsBigger(int Number, int[] SomeArray)
    {
        if (Number > SomeArray.Length - 1 || Number < 0)
        {
            Console.WriteLine("This position is outside the range of the array.");
        }
        else if (Number + 1 == SomeArray.Length || Number == 0)
        {
            Console.WriteLine("The number on this position have only one neighbor. ");
        }
        else if (SomeArray[Number] > SomeArray[Number + 1] && SomeArray[Number] > SomeArray[Number - 1])
        {
            Console.WriteLine("Number {0} is bigger than its neighbors.", SomeArray[Number]);
        }
    }

    static void Main()
    {
        int index = 0;
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
        int NumToLookFor = 0;
        Console.WriteLine("On what position is the number which you want to check?");
        NumToLookFor = int.Parse(Console.ReadLine());
        IsBigger(NumToLookFor, SomeArray);
    }
}

