using System;

class ReplaceTagsInHTML
{
    static void Main()
    {
        Console.WriteLine("Enter your html below:");
        string htmlText = Console.ReadLine();
        htmlText = htmlText.Replace("<a href=\"", "[URL=");
        htmlText = htmlText.Replace("\">", "]");
        htmlText = htmlText.Replace("</a>", "[/URL]");
        Console.WriteLine("Converted text: \n{0}",htmlText);
    }
}

