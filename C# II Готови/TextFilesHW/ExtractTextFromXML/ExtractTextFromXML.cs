using System;
using System.IO;
using System.Xml;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        bool write = false;
        XmlDocument fileXML = new XmlDocument();
        fileXML.Load("../../textXML.txt");
        Console.Write("Text without tags:");
        foreach (char sim in fileXML.OuterXml)
        {
            if (sim == '<')
            {
                write = false;
                Console.WriteLine();
            }
            if (write == true)
            {
                Console.Write(sim);
            }
            if (sim == '>')
            {
                write = true;
            }
        }
        
    }
}

