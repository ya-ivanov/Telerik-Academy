using System;

class FillStringWithAsterisk
{
    static void Main()
    {
        Console.WriteLine("Enter your string below:");
        string myStr = Console.ReadLine();
        if (myStr.Length > 20)
        {
            Console.WriteLine("Your string should be maximum 20 characters.");
        }
        else
        {
            int addAsterisk = 20 - myStr.Length;
            myStr = string.Concat(myStr, new string('*', addAsterisk));
            Console.WriteLine(myStr);
        }
    }
}

