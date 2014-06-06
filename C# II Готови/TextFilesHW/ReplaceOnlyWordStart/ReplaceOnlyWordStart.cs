using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceOnlyWordStart
{
    class ReplaceOnlyWordStart
    {
        static void Main()
        {
            Regex replace = new Regex(@"\bstart\b");

            string line = "";
            StreamWriter write = new StreamWriter("../../replaced.txt", false);
            StreamReader read = new StreamReader("../../toReplace.txt");
            line = read.ReadLine();
            while (line != null)
            {
                
                line = replace.Replace(line, "finish");
                write.WriteLine(line);
                line = read.ReadLine();
            }
            read.Dispose();
            write.Dispose();
            Console.WriteLine("Done!");
            Console.WriteLine("File saved in root directory");
        }
    }
}
