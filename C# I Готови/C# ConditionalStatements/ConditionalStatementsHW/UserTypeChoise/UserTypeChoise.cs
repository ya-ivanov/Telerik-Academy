using System;

class UserTypeChoise
{
    static void Main()
    {
        Console.WriteLine("What kind of variable do you want to enter? int - 1/double - 2/string - 3");
        int choice = int.Parse(Console.ReadLine());
        int SomeInt;
        double SomeDouble;
        string SomeString;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Okay. Enter your integer bellow:");
                SomeInt = int.Parse(Console.ReadLine());
                Console.WriteLine(SomeInt + 1);
                break;

            case 2:
                Console.WriteLine("Okay. Enter your double bellow:");
                SomeDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(SomeDouble + 1);
                break;
            case 3:
                Console.WriteLine("Okay. Enter your string bellow:");
                SomeString = (Console.ReadLine());
                Console.WriteLine(SomeString + "*");
                break;
        }
    }
}

