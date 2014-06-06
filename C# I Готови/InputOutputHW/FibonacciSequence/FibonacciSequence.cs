using System;

class FibonacciSequence
{
    static void Main()
    {
        int last1 = 0, last2 = 1, printedNum = 0;
        int membersCount = 0;
        int memberNbr = 2;
        Console.WriteLine("1. 0");
        int SUM=0;
        int N = 5;
        do
        {
            printedNum = last1 + last2;
            Console.WriteLine("{0}. {1}", memberNbr, printedNum);
            SUM = SUM + printedNum;

            memberNbr++;
            last2 = last1;
            last1 = printedNum;
            membersCount++;
        } while (memberNbr < N+1);
        Console.WriteLine(SUM);
    }
}