using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static string Concatenate(string firstFile, string secondFile)
    {
       return String.Concat(firstFile, secondFile);
    }

    static string ReadFiles(string path)
    {
        string textFile = null;
        using (System.IO.StreamReader ReadFile = new System.IO.StreamReader(path))
        {
            textFile = ReadFile.ReadToEnd();
        }
        return textFile;
    }
    
    static void Main()
    {
        string textOne = ReadFiles("../../firstT.txt");
        string textTwo = ReadFiles("../../secondT.txt");
        Console.WriteLine("First File:\n{0}", textOne);
        Console.WriteLine("Second File:\n{0}", textTwo);
        Console.WriteLine("Concatenated:\n{0}" ,Concatenate(textOne, textTwo));
    }
}

