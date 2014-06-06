using System;

class MaximalSumOfKElements
{
    static void Main()
    {
        int index = 0;
        int BestSum = 0;
        Console.WriteLine("Enter N below:");
        int NumN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements to get the best sum from:");
        int NumK = int.Parse(Console.ReadLine());
        if (NumK > NumN)
        {
            Console.WriteLine("Your K number is too big. It should be less or equal to your array's elements!");
        }
        else
        {
            int[] SomeArray = new int[NumN];
            Console.WriteLine("Enter your array:");
            for ( ;index < SomeArray.Length; index++)
            {
                Console.Write("Element [{0}] = ", index);
                SomeArray[index] = int.Parse(Console.ReadLine());
            }
            Array.Sort(SomeArray);
            for (; NumK > 0; NumK--)
            {
                BestSum = BestSum + SomeArray[SomeArray.Length - NumK];
            }
            Console.WriteLine("The best sum is {0}.", BestSum);
        }
     }
}

