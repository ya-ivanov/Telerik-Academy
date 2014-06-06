using System;

class EntireASCIITable
{
    static void Main()
    {
        int CharCode = 0;
        for (CharCode = 0; CharCode < 32; CharCode = CharCode + 1)
        {
            char RealChar = (char)CharCode;
            Console.WriteLine("Char: {0} || Code: {1}", "This code represents control, not value.", CharCode);
        }
        for (CharCode = 32; CharCode < 128; CharCode = CharCode + 1)
        {
            char RealChar = (char)CharCode;
            Console.WriteLine("Char: {0} || Code: {1}", RealChar, CharCode);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Above you see the ASCII table.");
        Console.WriteLine("Do you want to see the ASCII table again, but with the controls? Yes-1, No-0");
        byte answer = 1;
        answer = byte.Parse(Console.ReadLine());
        if (answer == 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            for (CharCode = 0; CharCode < 128; CharCode = CharCode + 1)
            {
                char RealChar = (char)CharCode;
                Console.WriteLine("Char: {0} || Code: {1}", RealChar, CharCode);
            }
        }
    }
}

