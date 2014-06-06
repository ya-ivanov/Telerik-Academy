using System;
using System.Collections.Generic;
using System.Numerics;

class IntegerMethods
{
    static BigInteger GetProduct(int[] someArr)
    {
        int index = 0;
        BigInteger sum = 1;
        for (; index < someArr.Length; index++)
        {
            sum *= someArr[index];
        }
        return sum;
    }

    static BigInteger GetSum(int[] someArr)
    {
        int index = 0;
        BigInteger sum = 0;
        for (; index < someArr.Length; index++)
        {
            sum += someArr[index];
        }
        return sum;
    }

    static int GetMin(int[] someArr)
    {
        int index = 0;
        int min = int.MaxValue;
        for (;index < someArr.Length ;index++ )
        {
            if (someArr[index] < min)
            { 
                min = someArr[index];
            }
        }
        return min;
    }

    static double CalculateAverage(int[] someArr)
    {
        double length = someArr.Length;
        double sum = 0;
        foreach (int num in someArr)
        {
            sum += num;
        }
        return sum / length;
    }

    static int GetMax(int[] someArr)
    {
        int index = 0;
        int biggest = 0;
        int currentBiggest = 0;
        for (; index < someArr.Length - 1; index++)
        {
            if (someArr[index] > someArr[index + 1])
            {
                currentBiggest = someArr[index];
                if (currentBiggest > biggest)
                {
                    biggest = currentBiggest;
                }
            }
            else
            {
                currentBiggest = 0;
            }
        }
        if (someArr[someArr.Length - 1] > biggest)
        {
            biggest = someArr[someArr.Length - 1];
        }
        return biggest;
    }

    static void Main()
    {
        BigInteger result = 0;
        double averageResult = 0;
        int[] someArr = { 20,20, 20, 20, 20 ,20, 20, 19, 20, 20};
        averageResult = CalculateAverage(someArr);
        Console.WriteLine("The average is {0}", result);
        result = GetMax(someArr);
        Console.WriteLine("The biggest number in your array is {0}.", result);
        result = GetMin(someArr);
        Console.WriteLine("The minimal number in your array is {0}", result);
        result = GetSum(someArr);
        Console.WriteLine("The sum from all the elements in the array is {0}.", result);
        result = GetProduct(someArr);
        Console.WriteLine("The product from all the elements in the array is {0}.", result);

        
        

    }
}

