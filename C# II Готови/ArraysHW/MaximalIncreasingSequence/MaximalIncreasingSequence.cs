using System;
using System.Collections.Generic;
class MaximalIncreasingSequence
{
    static void Main()
    {
        int index = 0;
        int SomeArrayElements = 0;
        int CurrentSeq = 1;
        int LongestSeq = 1;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] SomeArray = new int[SomeArrayElements];
        List<int> SpecialNumbers = new List<int>();
        Console.WriteLine("Enter your array:");
        Console.Write("Element [{0}] = ", index);
        SomeArray[index] = int.Parse(Console.ReadLine());
        for (index = 1; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
            if ((SomeArray[index - 1] + 1) == SomeArray[index])
            {
                CurrentSeq++;
                if (CurrentSeq + 1 >= LongestSeq)
                {
                    LongestSeq = CurrentSeq;
                    SpecialNumbers.Add(SomeArray[index - 1]);
                }
            }
            else
            {
                CurrentSeq = 1;
            }
        }
        for (int i = 0; i < SpecialNumbers.Count; i++)
        {
            Console.Write("{0}, ", SpecialNumbers[i]);
        }
        Console.WriteLine("{0}", SpecialNumbers[SpecialNumbers.Count - 1]+1);


    }
}

