using System;

class FirstElementBiggerThanNeighbours
{
    static int IsBigger(int[] SomeArray)
    {
        int index = 1;
        int position = 0;
        int MinPosition = 100;
        for (; index < SomeArray.Length - 1; index++)
        {
            if (SomeArray[index - 1] < SomeArray[index] && SomeArray[index] > SomeArray[index + 1])
            {
                position = index;
                if (MinPosition > position)
                {
                    MinPosition = position;
                }
            }
            else
            {
                position = 0;
            }
        }
        if (MinPosition == 100)
        {
            MinPosition = -1;
        }
        return MinPosition;
    }

    static void Main()
    {
        int SpecialPosition = 0;
        int[] SomeArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        SpecialPosition = IsBigger(SomeArray);
        if (SpecialPosition == -1)
        {
            Console.WriteLine("There is no number that is bigger than it's neighbors.");
        }
        else
        {
            Console.WriteLine("The index of first the number that is bigger than its neighbors int the array is {0}.", SpecialPosition);
        }
    }
}


