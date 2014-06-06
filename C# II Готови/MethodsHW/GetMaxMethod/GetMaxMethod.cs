using System;

class GetMaxMethod
{
    static int GetMax(int  FirstNum, int SecondNum)
    {
        int Max = 0;
        if (FirstNum > SecondNum)
        {
            Max = FirstNum;
        }
        else if (SecondNum > FirstNum)
        {
            Max = SecondNum;
        }
        return Max;
    }
    static void Main()
    {
        Console.WriteLine("Enter three numbers below:");
        int FistNum = int.Parse(Console.ReadLine());
        int SecondNum = int.Parse(Console.ReadLine());
        int ThirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is {0}.", GetMax(GetMax(FistNum, SecondNum), ThirdNum));
    }
}

