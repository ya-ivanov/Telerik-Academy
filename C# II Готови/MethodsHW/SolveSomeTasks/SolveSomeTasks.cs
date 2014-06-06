using System;
using System.Collections.Generic;


class SolveSomeTasks
{
    static double CalCulateAverage(int[] someArr)
    {
        double length = someArr.Length;
        double sum = 0;
        foreach (int num in someArr)
        {
            sum += num;
        }
        return sum / length;
    }

    static decimal ReverseDigit(int somenum)
    {
        List<char> Container = new List<char>();
        string strNum = somenum.ToString();
        foreach (char someChar in strNum)
        {
            Container.Add(someChar);
        }
        Container.Reverse();
        strNum = "";
        foreach (var item in Container)
        {
            strNum += item;
        }
        return decimal.Parse(strNum);
    }

    static double SolveEquaton(double a, double b)
    {
        return b / a;
    }

    static void Main()
    {
        int answer = 0;
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("--1--Reverse the digits of a number.\n--2--Calculate the average of a sequence of integers.");
        Console.WriteLine("--3--Solve a linear equation");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1)
        {
            Console.WriteLine("You choose \"1--Reverse the digits of a number.\"");
            Console.WriteLine("Enter your number below:");

            int someNum = int.Parse(Console.ReadLine());
            if (someNum < 0)
            {
                Console.WriteLine("Your number should be positive. Please try again.");
            }
            else
            {
                decimal result = 0;
                result = ReverseDigit(someNum);
                Console.WriteLine("Reversed: {0}", result);
            }
        }
        else if (answer == 2)
        {
            int index = 0;
            double result = 0;

            int SomeArrayElem = 0;
            Console.WriteLine("You choose \"2--Calculate the average of a sequence of integers.\"");
            Console.WriteLine("How many elements do you want your array to have?");
            SomeArrayElem = int.Parse(Console.ReadLine());
            if (SomeArrayElem < 1)
            {
                Console.WriteLine("The length of the array should be bigger than zero. Please try again.");
            }
            else
            {
                Console.WriteLine("Enter your  array:");
                int[] SomeArray = new int[SomeArrayElem];
                for (index = 0; index < SomeArray.Length; index++)
                {
                    Console.Write("Element [{0}] = ", index);
                    SomeArray[index] = int.Parse(Console.ReadLine());
                }
                result = CalCulateAverage(SomeArray);
                Console.WriteLine("The average is {0}", result);
            }
        }
        else if (answer == 3)
        {
            double a, b;
            Console.WriteLine("Enter A & B below:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a == 0.00)
            {
                Console.WriteLine("The equation cant be solved, because a = 0.");
            }
            else if (a == 0.00 | b == 0.00)
            {
                Console.WriteLine("Every X is solution.");
            }
            else
            {
                double result = 0;
                result = SolveEquaton(a, b);
                Console.WriteLine("X = {0}", result);
            }

        }
    }
}

