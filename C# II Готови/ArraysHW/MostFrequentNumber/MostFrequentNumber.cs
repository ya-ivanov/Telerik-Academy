using System;

class MostFrequentNumber
{
    static void Main()
    {
        int index = 0;
        int SomeArrayElem = 0;
        int CurrentTimesInArray = 1;
        int MostTimesInArray = 1;
        int MostFreqNumber = 0;
        Console.WriteLine("How many elements do you want your array to have?");
        SomeArrayElem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your  array:");
        int[] SomeArray = new int[SomeArrayElem];
        for (index = 0;index < SomeArray.Length ;index++ )
        {
            Console.Write("Element [{0}] = ", index);
            SomeArray[index] = int.Parse(Console.ReadLine());
        }
        Array.Sort(SomeArray);
        for (index = 1; index < SomeArray.Length; index++)
        {
            //Console.WriteLine("Element [{0}] = {1}",index, SomeArray[index]);
            if (SomeArray[index - 1] == SomeArray[index])
            {
                CurrentTimesInArray++;
                if (CurrentTimesInArray > MostTimesInArray)
                {
                    MostTimesInArray = CurrentTimesInArray;
                    MostFreqNumber = SomeArray[index];
                }
            }
            else 
            {
                CurrentTimesInArray = 1;
            }
        }
        Console.WriteLine("The most frequent number in the array is: {0}",MostFreqNumber);
    }
}

