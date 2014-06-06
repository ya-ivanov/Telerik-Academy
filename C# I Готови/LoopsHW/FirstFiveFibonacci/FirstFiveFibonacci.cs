using System;

class FirstFiveFibonacci
{
    static void Main()
    {
        int last1 = 0, last2 = 1, printedNum = 0;
        int membersCount = 0;
        int memberNbr = 2;
        int N = 0;
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("________________________________");
        Console.WriteLine("1. 0");
        int SUM = 0;
        do
        {
            printedNum = last1 + last2;
            Console.WriteLine("{0}. {1}", memberNbr, printedNum);
            SUM = SUM + printedNum;
            memberNbr++;
            last2 = last1;
            last1 = printedNum;
            membersCount++;
        } while (memberNbr < N + 1);
        Console.WriteLine("________________________________");
        Console.WriteLine("The sum of the first {0} is {1}", memberNbr - 1 ,SUM);
        
    }
}

