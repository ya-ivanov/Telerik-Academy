using System;

class Program
{
    static void Main()
    {
        string FirstName;
        string FamilyName;
        byte Age;
        char Genger;
        int IDNbr;
        int EmployeeNbr;
        Console.WriteLine("Enter employee's First Name: ");
        FirstName = Console.ReadLine();
        Console.WriteLine("Enter employee's Family Name: ");
        FamilyName = Console.ReadLine();
        Console.WriteLine("Enter employee's Age: ");
        Age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee's genger(m/f): ");
        Genger = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee's ID number: ");
        IDNbr = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee's unique number (27560000 to 27569999): ");
        EmployeeNbr = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Employee's unique number should be from 27560000 to 27569999. Enter new number bellow:");
            EmployeeNbr = int.Parse(Console.ReadLine());
        } while (EmployeeNbr > 27569999 || EmployeeNbr < 27560000);
        Console.Clear();
        Console.WriteLine("New employee signed successfully! Entered information: ");
        Console.WriteLine("First name: {0}",FirstName);
        Console.WriteLine("Family name: {0}",FamilyName);
        Console.WriteLine("Age: {0}",Age);
        Console.WriteLine("Genger: {0}",Genger);
        Console.WriteLine("ID number: {0}",IDNbr);
        Console.WriteLine("Employee unique number: {0}",EmployeeNbr);
    }
}

