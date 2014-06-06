using System;
class PrintSquareNum
{
    static void Main()
    {
        double SqrNum = (12345*12345);
        //Other way: ..... = Math.Pow(12345, 2);
        Console.WriteLine(SqrNum);

        //Bellow is for SQUARE ROOT
        double MySqrRoot = Math.Sqrt(12345);
        Console.WriteLine(MySqrRoot);
    }
}
