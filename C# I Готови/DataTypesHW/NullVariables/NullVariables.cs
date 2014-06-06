using System;

class NullVariables
{
    static void Main()
    {
        int IntNbr = 5;
        double DoubleNumber = 6.215;
        Console.WriteLine(IntNbr);
        Console.WriteLine(DoubleNumber);
        IntNbr = null;
        Console.WriteLine(IntNbr);

    }
}

