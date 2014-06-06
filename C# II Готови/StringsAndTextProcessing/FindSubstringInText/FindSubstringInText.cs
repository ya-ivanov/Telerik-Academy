using System;
using System.Text.RegularExpressions;

class FindSubstringInText
{
    static void Main()
    {
        string yourText = @"Look, if you had one shot, or one opportunity
            To seize everything you ever wanted in one moment
            Would you capture it or just let it slip?--Eminem";
        yourText = yourText.ToLower();
        Console.WriteLine("Enter a substring below, to search for it in the text.");
        string txtToFind = Console.ReadLine();
        int ocurre = Regex.Matches(yourText, txtToFind.ToLower().Trim()).Count;
        Console.WriteLine(ocurre);
        
    }
}

