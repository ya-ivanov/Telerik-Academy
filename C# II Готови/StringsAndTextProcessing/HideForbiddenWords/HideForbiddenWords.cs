using System;

class HideForbiddenWords
{
    static void Main()
    {
        string someText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        for (int index = 0; index < forbiddenWords.Length; index++)
        {
            if (someText.ToLower().Contains(forbiddenWords[index].ToLower()))
            {
                someText = someText.ToLower().Replace(forbiddenWords[index].ToLower(), new string('*', forbiddenWords[index].Length));
            }
        }
        Console.WriteLine(someText);
    }
}

