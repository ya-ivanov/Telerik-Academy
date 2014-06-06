using System;
using System.Collections.Generic;
class ReverseString
{
    static void Main()
    {
        string someStr = "";
        Console.WriteLine("Enter your word below:");
        someStr = Console.ReadLine();
        List<string> strArray = new List<string>();
        foreach (char letter in someStr)
        {
            strArray.Add(letter.ToString());
        }
        strArray.Reverse();
        foreach (string item in strArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

