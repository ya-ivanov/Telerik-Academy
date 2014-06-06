using System;

class AlphabetArray
{
    static void Main()
    {
        char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                               'j', 'k', 'l','m', 'n', 'o', 'p', 'q', 'r',
                                's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        Console.WriteLine("Enter your word below:");
        string word = Console.ReadLine().ToLower();
        foreach (char letter in word)
        {
            int CurrentIndex = Array.BinarySearch(alphabet, letter);
            Console.WriteLine("Letter {0} is on {1} position in English alphabet.", letter, CurrentIndex + 1);
        }
    }
}

