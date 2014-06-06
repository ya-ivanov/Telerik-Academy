using System;
using System.Numerics;

class FactorialRange
{
    static BigInteger CalcFactorial(int number)
    {
        BigInteger fact = 1;
        int times = 1;
        for (;times < number + 1;times++)
        {
            fact = fact * times;
        }
        return fact;
    }

    static void Main()
    {
        int index = 1;
        BigInteger result = 0;
        for (;index< 101 ;index++ )
        {
            result = CalcFactorial(index);
            Console.WriteLine("Factorial from {0} is {1}.",index,result);
        }
        
    }
}
