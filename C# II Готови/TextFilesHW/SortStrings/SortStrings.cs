using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class SortStrings
{
    static void Main()
    {
        string line = "";
        List<string> container = new List<string>();
        StreamWriter write = new StreamWriter("../../sorted.txt", false);
        StreamReader read = new StreamReader("../../unsorted.txt");
        while (line != null)
        {
            line = read.ReadLine();
            container.Add(line);
        }
        read.Dispose();
        container.Sort();
        foreach (string item in container)
        {
            write.WriteLine(item);
        }
        write.Dispose();
        Console.WriteLine("Sorted!");
    }
}

