using System;
using System.Net;
using System.Diagnostics;

class DownloadFile
{
    static void Main()
    {
        char answer;
        bool downloaded = true;
        string url = "http://i.imgur.com/GRNQi.jpg";
        string currDir = AppDomain.CurrentDomain.BaseDirectory;
        string fileName = "";
        WebClient webC = new WebClient();
        try
        {
            Console.WriteLine("Enter the name of the file below (example: myfile.txt):");
            fileName = Console.ReadLine();
            Console.WriteLine("Download Started. Please wait....");
            webC.DownloadFile(url, currDir + fileName);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The provided url or local path is not valid.");
            downloaded = false;
        }
        catch (System.Net.WebException)
        {
            Console.WriteLine("Could not find the file. Please check the given url.");
            downloaded = false;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The provided url or local path is not valid.");
            downloaded = false;
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method doesnt allow to read/write to the file while downloading.");
            downloaded = false;
        }
        finally
        {
            webC.Dispose();
            if (downloaded == true)
            {
                Console.WriteLine("Download Completed!");
                Console.WriteLine("File saved in {0}.", currDir + fileName);
                Console.WriteLine("Open file? Yes-Y  No-N");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'y' || answer == 'Y')
                {
                    Process.Start(currDir + fileName);
                }
                else
                {
                    Console.WriteLine("Okay. Bye.");
                }
            }
            else
            {
                Console.WriteLine("Error ocurred during file downloading. Please try again.");
            }
        }
    }
}

