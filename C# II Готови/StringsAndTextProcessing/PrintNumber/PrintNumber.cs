using System;

class PrintNumber
{
    static void Main()
    {
        Console.WriteLine("Enter your number below:");
        int someNum = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15:D}: Decimal\n{0,15:X}: Hexadecimal\n{0,15:P}: Percent\n{0,15:E}: Scientific notation", someNum);
    }
}

