using System;
using System.Text;
using System.IO;

class ReplaceStart
{
    static void Main()
    {
        
        string line = "";
        StreamWriter write = new StreamWriter("../../replaced.txt");
        StreamReader read = new StreamReader("../../toReplace.txt");
        line = read.ReadLine();
        while (line != null)
        {
            line = line.Replace("start", " finish");
            write.WriteLine(line);
            line = read.ReadLine();
        }
        read.Dispose();
        write.Dispose();
        Console.WriteLine("Done!");
    }
}

