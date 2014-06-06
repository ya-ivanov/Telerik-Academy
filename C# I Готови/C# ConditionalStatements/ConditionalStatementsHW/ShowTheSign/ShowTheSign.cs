using System;

class ShowTheSign
{
    static void Main()
    {
        double Nbr1 = 0;
        double Nbr2 = 0;
        double Nbr3 = 0;
        Console.WriteLine("Enter three numbers bellow.");
        Nbr1 = double.Parse(Console.ReadLine());
        Nbr2 = double.Parse(Console.ReadLine());
        Nbr3 = double.Parse(Console.ReadLine());
        int Counter = 0;
        if (Nbr1 < 0)
        {
            Counter++;
        }
        if (Nbr2 < 0)
        {
            Counter++;
        }
        if (Nbr3 < 0)
        {
            Counter++;
        }
        switch (Counter)
        {
            case 2:
                Console.WriteLine("The product of {0}, {1}, {2} is a negative number (Ex: -X)", Nbr1, Nbr2, Nbr3);
                break;
            case 1:
            case 0:
                Console.WriteLine("The product of {0}, {1}, {2} is a positive number (Ex: +X)", Nbr1, Nbr2, Nbr3);
                break;
            default:
                Console.WriteLine("Please enter valid numbers!");
                break;
        }
    }
}

