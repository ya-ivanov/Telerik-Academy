using System;

class Dictionary
{
    static void Main()
    {
        bool foundWord = false;
        int foundWords = 0;
        string[] dictionary = { 
                            ".NET - platform for applications from Microsoft",
                            "HTML5 - is a markup language for structuring and presenting content for the World Wide Web and a core technology of the Internet.",
                            "CSS - Cascading Style Sheets (CSS) is a style sheet language used for describing the presentation semantics (the look and formatting) of a document written in a markup language.",
                            "C# - (pronounced see sharp) is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.",
                            "COMPUTER - is a general purpose device that can be programmed to carry out a finite set of arithmetic or logical operations. Since a sequence of operations can be readily changed, the computer can solve more than one kind of problem.",
                            "NAMESPACE - hierarchical organization of classes",
                            "CLR - The Common Language Runtime (CLR) is the virtual machine component of Microsoft's .NET framework and is responsible for managing the execution of .NET programs.",
                            "COMPILER - A compiler is a computer program (or set of programs) that transforms source code written in a programming language (the source language) into another computer language (the target language, often having a binary form known as object code)."
                            };
        Console.WriteLine("Enter your word below:");
        string word = Console.ReadLine();
        Console.WriteLine("Words starting with \"{0}\" in our dictionary: Please wait...", word);
        for (int index = 0; index < dictionary.Length; index++)
        {
            if (dictionary[index].StartsWith(word.ToUpper()))
            {
                foundWords++;
                Console.WriteLine("[{0}] - {1}",foundWords,dictionary[index]);
                Console.WriteLine("");
                foundWord = true;
            }
        }
        if (foundWord == false)
        {
            Console.WriteLine("Sorry, but we don't have any information about your word.");
        }

    }
}

