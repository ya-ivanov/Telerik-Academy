using System;
class PrintMemberSequence
{
    static void Main()
    {
        for (int numbr = 2; numbr < 11; numbr = numbr + 2)
        {
            Console.Write(" {0}, -{1},", numbr, numbr + 1);
            //This bellow was my first solution, but  I think it's confusing, so I changed it
            // Console.Write(numbr + ", -" + (numbr+1) + ", ");
        }
        Console.WriteLine("");
    }
}

