using System;

class SortValues
{
    static void Main()
    {
        double FirstNum = double.Parse(Console.ReadLine());
        double SecondNum = double.Parse(Console.ReadLine());
        double ThirdNum = double.Parse(Console.ReadLine());
        if (FirstNum > SecondNum)
        {
            if (FirstNum > ThirdNum && FirstNum > SecondNum )
            {
                Console.Clear();
                Console.WriteLine(FirstNum);
                if (SecondNum > ThirdNum)
                {
                    Console.WriteLine(SecondNum);
                    Console.WriteLine(ThirdNum);
                }
                else
                {
                    Console.WriteLine(ThirdNum);
                    Console.WriteLine(SecondNum);
                }
            }
        }
        if (SecondNum > FirstNum && SecondNum > ThirdNum)
        {
            Console.Clear();
            Console.WriteLine(SecondNum);
            if (FirstNum > ThirdNum)
            {
                Console.WriteLine(FirstNum);
                Console.WriteLine(ThirdNum);
            }
            else
            {
                Console.WriteLine(ThirdNum);
                Console.WriteLine(FirstNum);
            }
            
        }
        if (ThirdNum > FirstNum && ThirdNum > SecondNum)
        {
            if (ThirdNum > SecondNum)
            {
                Console.Clear();
                Console.WriteLine(ThirdNum);
                if (FirstNum > SecondNum)
                {
                    Console.WriteLine(FirstNum);
                    Console.WriteLine(SecondNum);
                }
                else if (FirstNum < SecondNum)
                {
                    Console.WriteLine(SecondNum);
                    Console.WriteLine(FirstNum);
                }
            }
        }
        
    }

}

