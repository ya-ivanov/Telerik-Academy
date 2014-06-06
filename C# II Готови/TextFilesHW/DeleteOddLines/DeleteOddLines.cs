using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        string line = "";
        List<string> allTxt = new List<string>();
        int lineNum = 0;
        using (StreamReader read = new StreamReader("../../someText.txt"))
        {
            while (line != null)
            {
                lineNum++;
                line = read.ReadLine();
                if (lineNum % 2 == 0)
                {
                    allTxt.Add(line);
                }
            }
        }
        using (StreamWriter write = new StreamWriter("../../someText.txt", false))
        {
            foreach (string item in allTxt)
            {
                write.WriteLine(item);
            }
            Console.WriteLine("Done! All odd lines removed.");

        }

    }
}

