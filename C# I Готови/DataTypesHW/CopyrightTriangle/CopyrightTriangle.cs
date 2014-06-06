using System;

class Program
{
    static void Main()
    {
        int Row1 = 0;
        int Row2 = 0;
        int Row3 = 0;
        int CopyRight = 0169;
        for (Row1 = 0; Row1 < 3; Row1++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("{0}", (char)CopyRight);
        for (Row2 = 0; Row2 < 2; Row2++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("{0}{0}{0}", (char)CopyRight);

        for (Row3 = 0; Row3 < 1; Row3++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("{0}{0}{0}{0}{0}", (char)CopyRight);

    }
}

