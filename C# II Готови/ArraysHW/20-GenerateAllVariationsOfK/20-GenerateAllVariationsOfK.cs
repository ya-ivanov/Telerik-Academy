using System;
using System.Collections.Generic;

class _20_GenerateAllVariationsOfK
{
    //With bigger numbers it may take a while!
    static int NumK = int.Parse(Console.ReadLine());
    static int NumN = int.Parse(Console.ReadLine());

    static void Variations(int[] SomeArray, int index)
    {
        if (index == SomeArray.Length)
        {
            WriteSomeArray(SomeArray);
        }
        else
        {
            for (int i = 1; i <= NumN; i++)
            {
                SomeArray[index] = i;
                Variations(SomeArray, index + 1);
            }
        }
    }
    static void WriteSomeArray(int[] SomeArray)
    {
        for (int i = 0; i < SomeArray.Length; i++)
        {
            Console.Write("{0}-", SomeArray[i]);
        }
        Console.WriteLine();
    }    

    static void Main()
    {
        Console.WriteLine("K = {0}", NumK);
        Console.WriteLine("N = {0}", NumN);
        Console.WriteLine("Variations: ");
        int[] variationsArray = new int[NumK];
        Variations(variationsArray, 0);
        ////////////Array---------Index
    }
}
