using System;

class ExtractSentencesFromText
{
    static void Main()
    {
        string someText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] strArray = someText.ToLower().Split('.');
        Console.WriteLine("Enter the word that you want to look for:");
        string wordToFind = Console.ReadLine().ToLower();
        for (int index = 0; index < strArray.Length; index++)
        {
            if (strArray[index].ToLower().Contains(" " + wordToFind + " ") || strArray[index].ToLower().Contains(wordToFind + " ") || strArray[index].ToLower().Contains(" " + wordToFind))
            {
                Console.WriteLine(strArray[index].Trim() + ".");
            }
        }
    }
}

