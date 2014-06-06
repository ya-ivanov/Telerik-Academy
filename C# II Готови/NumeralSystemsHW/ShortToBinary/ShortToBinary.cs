using System;

class ShortToBinary
{
    static void Main()
    {
        Console.WriteLine("Input your short type number below:");
        short sNumber = short.Parse(Console.ReadLine());
        string endResult = Convert.ToString(sNumber, 2).PadLeft(16, '0');
        while (endResult.StartsWith("0"))
        {
            endResult = endResult.Remove(0, 1);
        }
        Console.WriteLine(endResult);
    }
}

