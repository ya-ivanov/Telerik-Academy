using System;

class DecimalToHexadecimal
{
    static int ToHex(int decNum)
    {
        int reminder = 0;
        string result = "";
        while (decNum > 0)
        {
            reminder = (decNum % 16);
            decNum /= 16;
            if (reminder == 10)
                result = "A" + result;
            else if (reminder == 11)
                result = "B" + result;
            else if (reminder == 12)
                result = "C" + result;
            else if (reminder == 13)
                result = "D" + result;
            else if (reminder == 14)
                result = "E" + result;
            else if (reminder == 15)
                result = "F" + result;
            else
                result = reminder.ToString() + result;
        }
        return int.Parse(result);
    }

    static void Main()
    {
        int result;
        Console.WriteLine("Enter your decimal number below:");
        int actualNum = int.Parse(Console.ReadLine());
        result = ToHex(actualNum);
        Console.WriteLine("The binary representation of your number is {0}.",result);
    }
}

