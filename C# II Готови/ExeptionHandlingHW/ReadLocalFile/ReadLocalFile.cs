using System;

namespace ReadLocalFile
{
    class ReadLocalFile
    {
        static void ReadFile(string path)
        {

            try
            {
                System.IO.StreamReader ReadF = new System.IO.StreamReader(path);
                Console.WriteLine(ReadF.ReadToEnd());
            }
            catch (System.OutOfMemoryException)
            {
                Console.WriteLine("It seems that there is not enought memory to continue the given task.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter a valid file path.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid file path.");
            }
            catch (System.IO.PathTooLongException)
            {
                Console.WriteLine("The entered path is too long. ");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Cant find the directory specified.");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Cant find the file specified.");
            }
            catch (System.NotSupportedException)
            {
                Console.WriteLine("The given path is not valid.");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("You dont not have the required permissions to read this file.");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error ocureed while reading the file. Sorry for the inconvenience.");
            }
        }
       
        static void Main()
        {
            string path = "";
            Console.WriteLine("Enter your file path below:");
            path = Console.ReadLine();
            ReadFile(path);
        }
    }
}
