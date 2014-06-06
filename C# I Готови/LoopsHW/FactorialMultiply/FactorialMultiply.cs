using System;

class FactorialMultiply
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
        int TimesKN = 1;
        int FactK = 1;
        int FactN = 1;
        int FactKN = 1;
        for (; TimesKN < (K-N)+1; )
        {
            FactKN = FactKN * TimesKN;
            TimesKN++;
        }
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
        Console.WriteLine("K!= {0}", FactK);
        Console.WriteLine("N!= {0}", FactN);
        Console.WriteLine("N! * K! = {0}", (FactN * FactK));
        Console.WriteLine("N! * K! / (K-N)! = {0}", (FactN * FactK)/FactKN);
    }
}
//N!*K!/(K-N)!
