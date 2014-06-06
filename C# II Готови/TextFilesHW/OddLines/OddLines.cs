using System;

class OddLines
{
    static void Main()
    {
        int lineNum = 1;
        try
        {
            using (System.IO.StreamReader ReadFile = new System.IO.StreamReader("../../someText.txt"))
            {
                Console.WriteLine("Reading file...");
                string line = ReadFile.ReadLine();
                for (; line != null; lineNum++)
                {
                    if (lineNum % 2 != 0)
                    {
                        Console.WriteLine("[Line {0}] : {1}", lineNum, line);
                    }
                    line = ReadFile.ReadLine();
                }

            }
        }
        catch (System.IO.DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found.");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (System.IO.FileLoadException)
        {
            Console.WriteLine("There was an error while reading the file.");
        }
    }
}

