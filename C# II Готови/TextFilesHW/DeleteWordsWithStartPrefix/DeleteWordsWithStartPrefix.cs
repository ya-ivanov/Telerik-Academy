using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DeleteWordsWithStartPrefix
{
    class DeleteWordsWithStartPrefix
    {
        static void Main()
        {
            string line = "";
            using (StreamReader read = new StreamReader("../../testText.txt"))
            {
                line = read.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\btest\w{1,}", "");
                    Console.WriteLine(line);
                    line = read.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
    }
}
