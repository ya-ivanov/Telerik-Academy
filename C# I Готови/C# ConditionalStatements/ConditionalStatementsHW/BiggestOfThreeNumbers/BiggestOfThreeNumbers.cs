using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int FirstNum = int.Parse(Console.ReadLine());
        int SecondNum = int.Parse(Console.ReadLine());
        int ThirdNum = int.Parse(Console.ReadLine());
        if (FirstNum > SecondNum)
        {
            if (FirstNum > ThirdNum)
            {
                Console.WriteLine("The biggest number is {0}", FirstNum);
            }
            else if (ThirdNum > FirstNum)
            {
                Console.WriteLine("The biggest number is {0}", ThirdNum);
            }
        }
        else if (SecondNum > FirstNum)
        {
            if (SecondNum > ThirdNum)
            {
                Console.WriteLine("The biggest number is {0}", SecondNum);
            }
            else if (ThirdNum > SecondNum)
            {
                Console.WriteLine("The biggest number is {0}", ThirdNum);
            }
        }
        else if (ThirdNum > FirstNum)
        {
            if (ThirdNum > SecondNum)
            {
                Console.WriteLine("The biggest number is {0}", ThirdNum);
            }
            else if (SecondNum > ThirdNum)
            {
                Console.WriteLine("The biggest number is {0}", SecondNum);
            }
        }
        else
            Console.WriteLine("The Numbers are even.");
    }
}

