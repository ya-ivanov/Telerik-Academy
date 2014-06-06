using System;

class FactorialNK
{
    static void Main()
    {
        int K = 0;
        int N = 0;
        Console.WriteLine("Enter two numbers bellow:");
        K = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        int TimesK = 1;
        int TimesN = 1;
        int FactK=1;
        int FactN = 1;
        for (; TimesK < K + 1; )
        {
            FactK = FactK * TimesK;
            TimesK++;
        }
        for (; TimesN < N + 1; )
        {
            FactN = FactN * TimesN;
            TimesN++;
        }
        Console.WriteLine("K!= {0}",FactK);
        Console.WriteLine("N!= {0}",FactN);
        Console.WriteLine("N! / K! = {0}", FactN/FactK);
    }
}

