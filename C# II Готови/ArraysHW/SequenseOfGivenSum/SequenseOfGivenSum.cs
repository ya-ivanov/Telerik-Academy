using System;
using System.Collections.Generic;
//My program is only working, if the sequence starts from the begining of the array.
//Sorry about that :)  
class SequenseOfGivenSum
{
    static void Main(string[] args)
    {
        int[] SomeArray = { 5, -3, 15, 9, 1, 4, 2, 7, -8, 1, 7, 3, 3, 11, 2, 7};
        List<int> Container = new List<int>();
        int index = 0;
        Console.WriteLine("What number do you want to look for?");
        //Working with: 17, 43, 46, 57, 59 etc.
        int S = int.Parse(Console.ReadLine());
        int EndWith = 0;
        int times = 0;
        int Sum = 0;
        for (; index < SomeArray.Length; index++)
        {
            Sum = Sum + SomeArray[index];
            times++;
            if (SomeArray[index] > S)
            {
                times = 0;
                break;
            }
            if (Sum == S)
            {
                EndWith = index;
                break;
            }
        }
        try
        {
            int temp = 0;
            for (; times > 0; times--, temp++)
            {
                Container.Add(SomeArray[EndWith - temp]);
            }
            Container.Reverse();
            foreach (int item in Container)
            {
                Console.Write("{0} ", item);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Sum, not Found!");
        }
    }
}

