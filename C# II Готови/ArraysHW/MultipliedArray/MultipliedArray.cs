using System;

class MultipliedArray
{
    static void Main()
    {
        int[] SomeArray = new int[20];
        int index = 0;

        for ( ; index < 20 ;index++)
        {
            SomeArray[index] = index * 5;
            Console.WriteLine("SomeArray[{0}] = {1}", index, SomeArray[index]);
        }
    }
}

