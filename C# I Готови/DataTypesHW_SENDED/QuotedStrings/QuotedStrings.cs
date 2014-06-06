using System;
class QuotedStrings
{
    static void Main()
    {
        string WithEscapingQuotes = "The \"use\" of quotations causes dificuties.";
        string WithoutEscaping = @"The ""use"" of quotations causes dificuties.";
        Console.WriteLine(WithEscapingQuotes);
        Console.WriteLine(WithoutEscaping);
    }
}

