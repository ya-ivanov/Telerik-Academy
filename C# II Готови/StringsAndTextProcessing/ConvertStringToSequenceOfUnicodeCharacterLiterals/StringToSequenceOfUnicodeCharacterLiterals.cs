using System;
using System.Text;

class StringToSequenceOfUnicodeCharacterLiterals
{
    static void Main()
    {
        Console.WriteLine("Enter your text below:");
        string someTxt = Console.ReadLine();
        string converted = "";
        StringBuilder build = new StringBuilder();
        foreach (char simbol in someTxt)
        {
            build.AppendFormat("\\u{0:X4}", (int)simbol);
        }
        converted = build.ToString();
        Console.WriteLine("Converted:");
        Console.WriteLine(converted);
    }
}

