using System;
//I am using Kadane's algorithm. I found it from Telerik Forums Thread, about whis exercise
class SequenceOfMaximumSum
{
    static void Main()
    {
        int index = 0;
        int SUM = 0;
        int SomeArrayElem = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your  array:");
        int[] SomeArray = new int[SomeArrayElem];
        for (index = 0; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
        }

        int maxStart = SomeArray[0], maxEnd = SomeArray[0];
        int longestSequence = 1;
        int currentSequence = 1;
        int start = 0, startTemporary = 0;
        //Kadane's algorithm START---------------------///
        for (int i = 1; i < SomeArray.Length; ++i)
        {
            if (SomeArray[i] + maxEnd > SomeArray[i])
            {
                maxEnd = SomeArray[i] + maxEnd;
                currentSequence++;
            }

            else
            {
                maxEnd = SomeArray[i];
                startTemporary = i;
                currentSequence = 1;
            }
            if (maxEnd > maxStart)
            {
                maxStart = maxEnd;
                longestSequence = currentSequence;
                start = startTemporary;
            }
        }
        //Kadane's algorithm END-------------------///
        for ( index = start; index < start + longestSequence; ++index)
        {
            SUM = SUM + SomeArray[index];
            Console.Write("{0}, ", SomeArray[index]);
        }
        Console.WriteLine("\nBiggest sum is: {0}",SUM);
    }
}

