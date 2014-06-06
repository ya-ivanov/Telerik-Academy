using System;
using System.Text;

class ExtractPalindromes
{
    static void Main()
    {
        StringBuilder reversed = new StringBuilder();
        Console.WriteLine("Enter your text below:");
        string text = Console.ReadLine().ToLower().Replace(".", " ");
        char[] arr = new char[text.Length];
        string[] words = text.Split(' ');
        Console.WriteLine("\nPalindromes: ");
        foreach (string item in words)
        {
            arr = item.ToCharArray();
            Array.Reverse(arr);
            reversed.Clear();
            for (int index = 0; index < arr.Length; index++)
            {
                reversed.Append(arr[index]);
            }
            if (item == reversed.ToString())
            {
                Console.WriteLine(item);
            }
        }
    }
}

