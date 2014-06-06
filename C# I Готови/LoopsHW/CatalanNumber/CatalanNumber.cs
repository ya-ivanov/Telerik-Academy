using System;

class CatalanNumber
{
    static void Main()
    {
        int n = 0;
        Console.WriteLine("Enter N bellow [n > 0]:");
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        int Cn = 0;
        int N2 = n * 2;
        int Times2N = 1;
        int Fact2N = 1;
        int TimesN = 1;
        int FactN = 1;
        int Nplus1 = n + 1;
        int FactNplus1 = 1;
        int TimesNplus1 = 1;
        for (; TimesNplus1 < Nplus1 + 1; )
        {
            FactNplus1 = FactNplus1 * TimesNplus1;
            TimesNplus1++;
        }
        for (; Times2N < N2 + 1; )
        {
            Fact2N = Fact2N * Times2N;
            Times2N++;
        }
        for (; TimesN < n + 1; )
        {
            FactN = FactN * TimesN;
            TimesN++;
        }
        Console.WriteLine("___________________________");
        Console.WriteLine("n! = {0}",FactN);
        Console.WriteLine("(n+1)! = {0}",FactNplus1);
        Console.WriteLine("(2n)! = {0}\n\n",Fact2N);
        Cn = ((Fact2N) / ((FactNplus1) * FactN));
        Console.WriteLine("___________________________");
        Console.WriteLine(@"     (2n)!");
        Console.WriteLine("Cn= ----------  = {0}", Cn);
        Console.WriteLine(@"     (n+1)!*n!");
        Console.WriteLine("\n");
        
        




    }
}

