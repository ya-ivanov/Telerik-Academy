using System;
using System.Collections.Generic;

class MaximalElementInAPortionOfArray
{
    static int GetMax(int[] someArr, int givenIndex)
    {
        if (givenIndex > someArr.Length)
        {
            Console.WriteLine("Your index is outside the bounds of the array. The next result will be wrond!");
        }
        int biggest = 0;
        int currentBiggest = 0;
        for (; givenIndex < someArr.Length - 1; givenIndex++)
        {
            if (someArr[givenIndex] > someArr[givenIndex + 1])
            {
                currentBiggest = someArr[givenIndex];
                if (currentBiggest > biggest)
                {
                    biggest = currentBiggest;
                }
            }
            else
            {
                currentBiggest = 0;
            }
        }
        if (someArr[someArr.Length - 1] > biggest)
        {
            biggest = someArr[someArr.Length - 1];
        }
        return biggest;
    }

    static int[] SortAscending(int[] array)
    {
        int i, j, index;
        for (i = 1; i < array.Length; i++)
        {
            index = array[i];
            j = i;

            while ((j > 0) && (array[j - 1] > index))
            {
                array[j] = array[j - 1];
                j = j - 1;
            }

            array[j] = index;
        }
        return array;
    }
    static int[] SortDescending(int[] array)
    {
        int[] sorted = new int[array.Length];
        sorted = SortAscending(array);
        Array.Reverse(sorted);
        return sorted;
    }

    static void Main()
    {
        int maxValue = 0;
        int index = 0;
        int givenIndex = 0;
        int SomeArrayElements = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] someArray = new int[SomeArrayElements];
        Console.WriteLine("Enter your array:");
        Console.Write("Element [{0}] = ", index);
        someArray[index] = int.Parse(Console.ReadLine());
        for (index = 1; index < someArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            someArray[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("From what index should I start? From  ");
        givenIndex = int.Parse(Console.ReadLine());
        maxValue = GetMax(someArray, givenIndex);
        Console.WriteLine("_______________________________________________\n");
        Console.WriteLine("The biggest number in that portion is {0}.\n", maxValue);
        someArray = SortAscending(someArray);
        Console.WriteLine("Your array sorted in Ascending order:");
        foreach (int elem in someArray)
        {
            Console.Write("{0}, ",elem);
        }
        Console.WriteLine("\n_______________________________________________\n");
        Console.WriteLine("Your array sorted in Descending order:");
        someArray = SortDescending(someArray);
        foreach (int elem in someArray)
        {
            Console.Write("{0}, ", elem);
        }
        Console.WriteLine("\n\n");

    }
}

