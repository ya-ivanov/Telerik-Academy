using System;
using System.Text;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader readFirstFile = new StreamReader("../../textFileOne.txt");
        StreamReader readSecondFile = new StreamReader("../../textFileTwo.txt");
        int sameLines = 0;
        int diffLines = 0;
        string lineOne = "";
        string lineTwo = "";
        while (lineOne != null)
        {
            lineOne = readFirstFile.ReadLine();
            lineTwo = readSecondFile.ReadLine();
            if (lineOne == lineTwo)
            {
                sameLines++;
            }
            else
            {
                diffLines++;
            }
        }
        readFirstFile.Dispose();
        readSecondFile.Dispose();
        Console.WriteLine("Same lines: {0}", sameLines - 1);
        Console.WriteLine("Different lines: {0}", diffLines);
    }

}

