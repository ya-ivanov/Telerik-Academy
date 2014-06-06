using System;

class TenRandomValues
{
    static void Main()
    {
        Random randNum = new Random();
        for (int counter = 1 ;counter < 12 ;counter++ )
        {
            Console.WriteLine("Random password {0}: {1}", counter, randNum.Next(100, 201));
        }
    }
}

