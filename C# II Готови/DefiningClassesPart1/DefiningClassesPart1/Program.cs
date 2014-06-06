using System;

class Program
{
    static void Main()
    {
        Battery battery = new Battery();
        Display display = new Display();
        GSMhold gsm = new GSMhold();
        Console.WriteLine("Enter your gsm specification below:");
        Console.WriteLine("Model:");
        gsm.Model = Console.ReadLine();
        Console.WriteLine("Manifactuer:");
        gsm.Manufactuer = Console.ReadLine();
        Console.WriteLine("Owner:");
        gsm.Owner = Console.ReadLine();
        Console.WriteLine("Price:");
        gsm.Price = Console.ReadLine();
        Console.WriteLine("Battery:");
        Console.WriteLine("Hours Talk:");
        battery.hourstalk = double.Parse(Console.ReadLine());
        Console.WriteLine("Hours Idle:");
        battery.hoursIdle = double.Parse(Console.ReadLine());
        Console.WriteLine("Model:");
        battery.modelBtry = Console.ReadLine();
        Console.WriteLine("Display:\n Display size:");
        display.Size = double.Parse(Console.ReadLine());
        Console.WriteLine("Colors:");
        display.Colors = uint.Parse(Console.ReadLine());

        gsm.ToString();



        

    }
}

