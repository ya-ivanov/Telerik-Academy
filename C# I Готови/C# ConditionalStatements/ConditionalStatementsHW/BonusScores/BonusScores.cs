using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter the score bellow (1...9) :");
        int score = 0;
        score = int.Parse(Console.ReadLine());
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Bonus = {0}", score * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Bonus = {0}", score * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Bonus = {0}", score * 1000);
                break;
            case 0:
            default:
                Console.WriteLine("The score can not be 0 or something that is not a number! It can't be bigger than 9 also!");
                break;
        }
    }
}

