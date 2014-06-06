using System;
class MyAgeAfterTime
{
    static void Main()
    {
        Console.WriteLine("Write your years bellow:");
        int MyAge;
        MyAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("After 10 years you will be " + (MyAge + 10) + " years old.");
     }
}
