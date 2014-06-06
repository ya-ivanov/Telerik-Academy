using System;

class ReverseTheWordsInSentense
{
    static void Main()
    {
        Console.WriteLine("Enter your sentense below:");
        string[] sentence = Console.ReadLine().Split(' ');
        Array.Reverse(sentence);
        foreach (string str in sentence)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}

