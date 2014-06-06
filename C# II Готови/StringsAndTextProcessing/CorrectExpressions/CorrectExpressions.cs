using System;
using System.Collections.Generic;

class CorrectExpressions
{
    static void Main()
    {
        int openClosed = 0;
        Console.WriteLine("Enter your expession below:");
        string expression = Console.ReadLine();
        foreach (char simbol in expression)
        {
            if (simbol == '(')
            {
                openClosed++;
            }
            else if (simbol == ')')
            {

                if (openClosed == 0)
                {
                    openClosed--;
                    break;
                }
                else 
                {
                    openClosed--;
                }
            }
        }
        if (openClosed == 0)
        {
            Console.WriteLine("The expression is correct.");
        }
        else 
        {
            Console.WriteLine("The expression is wrong.");
        }
    }
}

