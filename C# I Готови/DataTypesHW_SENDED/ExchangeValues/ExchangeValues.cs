using System;

class ExchangeValues
{
    static void Main()
    {
        int FirstNumber = 5;
        int SecondNumber = 10;
        int Exchanger;
        Console.WriteLine("Before exchanging:");
        Console.WriteLine("\nFirst number = {0}\nSecon number = {1}", FirstNumber, SecondNumber);
        Exchanger = FirstNumber;
        FirstNumber = SecondNumber;
        SecondNumber = Exchanger;
        Console.WriteLine("\nÄfter exchanging:\n");
        Console.WriteLine("First number = {0}\nSecon number = {1}", FirstNumber, SecondNumber);
    }
}

