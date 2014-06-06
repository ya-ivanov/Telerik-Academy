using System;

class SortAnArray
{
    static void Main()
    {
        int index = 0;
        int SomeArrayElements = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        int[] SomeArray = new int[SomeArrayElements];
        Console.WriteLine("Enter your array:");

        for (;index < SomeArray.Length ;index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
        }
        
        int i, j, minimum, temporary;
        
        for (i = 0; i < SomeArrayElements - 1; i++)
        {
            minimum = i;
            for (j = i + 1; j < SomeArrayElements; j++)
            {
                if (SomeArray[j] < SomeArray[minimum])
                {
                    minimum = j;
                }
            }
            temporary = SomeArray[i];
            SomeArray[i] = SomeArray[minimum];
            SomeArray[minimum] = temporary;
        }
        Console.Write("\nSorted: ");
        for (index = 0; index < SomeArray.Length; index++)
        {
            Console.Write("{0}, ",SomeArray[index]);
            
        }
    }
}

