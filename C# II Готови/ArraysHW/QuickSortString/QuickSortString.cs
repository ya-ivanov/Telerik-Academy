using System;

class QuickSortString
{
    static void Main()
    {
        //Creating and initializating string array:
        int index = 0;
        int SomeArrayElements = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElements = int.Parse(Console.ReadLine());
        string[] SomeArray = new string[SomeArrayElements];
        Console.WriteLine("Enter your array:");

        for (; index < SomeArray.Length; index++)
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = Console.ReadLine();
        }
        Console.WriteLine("Unsorted: ");
        // Print the unsorted array
        for (int i = 0; i < SomeArray.Length; i++)
        {
            Console.Write(SomeArray[i] + " ");
        }

        Console.WriteLine();

        // Sort the array
        Quicksort(SomeArray, 0, SomeArray.Length - 1);
        Console.WriteLine("Sorted: ");
        
        for (int i = 0; i < SomeArray.Length; i++)
        {
            Console.Write(SomeArray[i] + " ");
        }
        Console.WriteLine();


    }
    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }
        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }


}

