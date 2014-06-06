using System;

class HelloString
{
    static void Main()
    {
        string Hello = "Hello";
        string World = "World";
        object HelloWorld = Hello + " " + World;
        string FromObjToString = (string)HelloWorld;
        Console.WriteLine(FromObjToString);
    }
}

