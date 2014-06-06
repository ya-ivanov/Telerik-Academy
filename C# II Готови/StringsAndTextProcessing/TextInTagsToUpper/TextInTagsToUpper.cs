using System;
using System.Text.RegularExpressions;

class TextInTagsToUpper
{
    static void Main()
    {
        Console.WriteLine("Enter you start tag below:");
        string startTag = Console.ReadLine();
        Console.WriteLine("Enter you end tag below:");
        string endTag = Console.ReadLine();
        string pattern = string.Join("(.*?)", startTag, endTag);
        Console.WriteLine("Enter your text below WITH tags.");
        string someTxt = Console.ReadLine();
        someTxt = Regex.Replace(someTxt, pattern, exists => exists.Groups[1].Value.ToUpper());
        Console.WriteLine(someTxt);
    }
}

