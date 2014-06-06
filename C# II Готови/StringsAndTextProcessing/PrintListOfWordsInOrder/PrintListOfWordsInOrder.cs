using System;

class PrintListOfWordsInOrder
{
    static void Main()
    {
        Console.WriteLine("Enter words below:");
        string yourTxt = Console.ReadLine();
        string[] order = yourTxt.Split(' ');
        Array.Sort(order);
        foreach (var item in order)
        {
            Console.WriteLine(item);
        }
    }
}

