using System;
using System.Collections.Generic;

class SequenceOfEqualElements
{
    static void Main()
    {
        int index = 0;
        int SomeArrayElements = 0;
        int CurrentSeq = 1;
        int LongestSeq = 1;
        int MasterNumber = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] SomeArray = new int[SomeArrayElements];
        Console.WriteLine("Enter your array:");
        
        Console.Write("Element [{0}] = ", index);
        SomeArray[index] = int.Parse(Console.ReadLine());
        
        
        for (index = 1 ; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
            if (SomeArray[index - 1] == SomeArray[index])
            {
                CurrentSeq++;
                if (CurrentSeq > LongestSeq)
                {
                    LongestSeq = CurrentSeq;
                    MasterNumber = SomeArray[index];
                }
            }
            else
            {
                CurrentSeq = 1;
            }
        }
        Console.Write("Longest Sequence: ");
        for (int counter = 0; counter < LongestSeq; counter++)
        {
            Console.Write("{0}, ", MasterNumber);
        }
        

    }
}
