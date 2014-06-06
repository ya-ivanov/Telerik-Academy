using System;

class LastDigitInEnglish
{
    static void LastDigit(string Num)
    {
        string[] Digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] DigitsWord = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        for (int index = 0; index < 10; index++)
        {
            if (Num.EndsWith(Digits[index]))
            {
                Console.WriteLine("Your number ends with {0} ({1}).", DigitsWord[index], Digits[index]);
            }
        }
    }
    static void Main()
    {
        string Number;
        Console.WriteLine("Enter your number below:");
        Number = Console.ReadLine();
        LastDigit(Number);
    }
}

