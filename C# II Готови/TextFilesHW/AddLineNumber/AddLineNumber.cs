using System;
using System.IO;
using System.Text;
namespace AddLineNumber
{
    class AddLineNumber
    {
        static void Main()
        {
            int lineNum = 1;
            StreamWriter write = new StreamWriter("../../withLines.txt");
            using (System.IO.StreamReader ReadFile = new System.IO.StreamReader("../../someText.txt"))
            {
                Console.WriteLine("Reading file...");
                string line = ReadFile.ReadLine();
                for (; line != null; lineNum++)
                {
                    write.WriteLine("[{0}] : {1}", lineNum, line);
                    line = ReadFile.ReadLine();
                }
                write.Dispose();
                Console.WriteLine("Finished!");
                Console.WriteLine("Saved file path: {0}", AppDomain.CurrentDomain.BaseDirectory + "withLines.txt");
            }
        }
    }
}
