using System;

class AskForNameMethod
{
    static void AskForName(string Name)
    {
        Console.Clear();
        Console.WriteLine("Hello, {0}!", Name);
        
    }
    static void Main()
    {
        Console.WriteLine("Whats your name?");
        AskForName(Console.ReadLine());
    }
}

