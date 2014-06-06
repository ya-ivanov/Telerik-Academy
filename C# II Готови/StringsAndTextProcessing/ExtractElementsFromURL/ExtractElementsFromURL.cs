using System;

class ExtractElementsFromURL
{
    static void Main()
    {
        Console.WriteLine("Enter your URL below:");
        string url = Console.ReadLine();
        int index = 0;
        if (url.StartsWith("http://") || url.StartsWith("https://"))
        {
            Console.Write("[protocol] = ");
            for (; index < url.Length; index++)
            {
                if (url[index] != ':')
                    Console.Write(url[index]);
                else
                    break;
            }
            index += 3;
            Console.Write("\n[server] = ");
            for (; index < url.Length; index++)
            {
                if (url[index] != '/')
                    Console.Write(url[index]);
                else
                    break;
            }
            Console.Write("\n[resourse] = ");
            if (index == url.Length || index + 1 == url.Length)
                Console.WriteLine("none");
            else
            {
                for (; index < url.Length; index++)
                {
                    Console.Write(url[index]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter valid URL.");
        }

    }
}

