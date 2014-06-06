using System;
using System.Collections.Generic;
class ExtractEmail
{
    static void Main()
    {
        Console.WriteLine("Enter your text below:");
        string txt = Console.ReadLine();
        string[] strArray = txt.Split(' ');
        bool exist = false;
        Console.WriteLine("Emails in this text:");
        foreach (string item in strArray)
        {
            if (item.Contains("@") || item.Contains("."))
            {
                if (item.IndexOf("@") >= 3 && item.IndexOf(".") > item.IndexOf("@") + 3)
                {
                    Console.WriteLine(item);
                    exist = true;
                }
            }
        }
        if (exist == false)
        {
            Console.WriteLine("Cant find emails in given text.");
        }
    }
}
