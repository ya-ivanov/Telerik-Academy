using System;

class CompareCharArrays
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
        char[] FirstArray = new char[FirstArrayElem];

        for (FirstArrayElem = 0; FirstArrayElem < FirstArray.Length; FirstArrayElem++)
        {
            Console.Write("Element {0} = ", FirstArrayElem);
            FirstArray[FirstArrayElem] = char.Parse(Console.ReadLine());
            
        }
        Console.WriteLine(new string ('_', 50));


        Console.WriteLine("\nHow many elements do you want your Second array to have?");
        SecondArrayElem = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second array:");
        char[] SecondArray = new char[SecondArrayElem];

        for (SecondArrayElem = 0; SecondArrayElem < SecondArray.Length; SecondArrayElem++)
        {
            Console.Write("Element {0} = ", SecondArrayElem);
            SecondArray[SecondArrayElem] = char.Parse(Console.ReadLine());
            
        }
        Console.WriteLine(new string('_', 50));

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
                Console.WriteLine("\nThe entered arrays ARE equal.");
            }
            else
            {
                Console.WriteLine("\nThe entered arrays are NOT equal.");
            }
        }
        else
        {
            Console.WriteLine("\nThe entered arrays are NOT equal.");
        }
        
    
    }
}

