using System;

class BinarySearchAlgorithm
{
    static void BinarySearch(int[] SomeArray, int numToSearch, int min, int max)
    {
        if (min > max)
        {
            Console.WriteLine("Number Not Found.");
            return;
        }
        int middleElement = (min + max) / 2;
        if (numToSearch > SomeArray[middleElement])
        {
            min = middleElement + 1;
        }
        else if (numToSearch < SomeArray[middleElement])
        {
            max = middleElement - 1;
        }
        else if (numToSearch == SomeArray[middleElement])
        {
            Console.WriteLine(middleElement);
            return;
        }
        BinarySearch(SomeArray, numToSearch, min, max);
    }
    static void Main()
    {
        int index = 0;
        int SomeArrayElements = 0;
        int NumToFind = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] SomeArray = new int[SomeArrayElements];
        Console.WriteLine("Enter your array:");

        for (; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(SomeArray);
        Console.WriteLine("What do you want to look for?");
        NumToFind = int.Parse(Console.ReadLine());

        BinarySearch(SomeArray, NumToFind, 0, SomeArrayElements - 1);
        /////1-Where to Search, 2-What to, 3-min, 4- max
        /////////////////////////look for

    }
}
//12.Write a program that finds the index of given element in a sorted array
//of integers by using the binary search algorithm (find it in Wikipedia).

