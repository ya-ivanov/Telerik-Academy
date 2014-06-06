using System;
static class Extension
{
    public static string FromRight(this string value, int length)
    {
        return value.Substring(value.Length - length);
    }
}
class CheckThirdDigitFromRight
{
    static void Main()
    {
        Console.WriteLine("Enter your number bellow:");
        string SomeNbr = Console.ReadLine();
        string RightResult = SomeNbr.FromRight(3);
        if (RightResult.StartsWith("7"))
        {
            Console.WriteLine("The third digit is 7.");
        }
        else
        {
            Console.WriteLine("The third digit is not 7.");
        }
    }
}

