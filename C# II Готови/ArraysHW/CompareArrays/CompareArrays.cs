using System;

class CompareArrays
{
    static void Main()
    {
        int equal = 0;
        int CurrentElem = 0;
        int FirstArrayElem;
        int SecondArrayElem;
        Console.WriteLine("How many elements do you want your First array to have?");
        FirstArrayElem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your first array:");
        int[] FirstArray = new int[FirstArrayElem];

        for (FirstArrayElem = 0; FirstArrayElem < FirstArray.Length; FirstArrayElem++)
        {
            Console.Write("Element {0} = ", FirstArrayElem);
            FirstArray[FirstArrayElem] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        
        Console.WriteLine("How many elements do you want your Second array to have?");
        SecondArrayElem = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second array:");
        int[] SecondArray = new int[SecondArrayElem];

        for (SecondArrayElem = 0; SecondArrayElem < SecondArray.Length; SecondArrayElem++)
        {
            Console.Write("Element {0} = ", SecondArrayElem);
            SecondArray[SecondArrayElem] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        if (FirstArray.Length == SecondArray.Length)
        {
            for (; CurrentElem < FirstArray.Length; CurrentElem++)
            {
                if (FirstArray[CurrentElem] == SecondArray[CurrentElem])
                {
                    equal++;
                }
            }
            if (equal == FirstArray.Length)
            {
                Console.WriteLine("The entered arrays ARE equal.");
            }
            else
            {
                Console.WriteLine("The entered arrays are NOT equal.");
            }
        }
        else
        {
            Console.WriteLine("The entered arrays are NOT equal.");
        }
        
    }
}

