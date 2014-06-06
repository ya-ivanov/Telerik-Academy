using System;

class SumOfStringValues
{
    static uint calculateSum(string nums)
    {
        uint sum = 0;
        string[] arrayStr = nums.Split(' ');
        foreach (string num in arrayStr)
        {
            sum += uint.Parse(num);
        }
        return sum;
    }

    static void Main()
    {
        uint result = 0;
        Console.WriteLine("Enter your numbers below <ex: 20 16 48 4 122>:");
        string numbers = Console.ReadLine();
        result = calculateSum(numbers);
        Console.WriteLine("The sum is {0}.", result);
    }
}

