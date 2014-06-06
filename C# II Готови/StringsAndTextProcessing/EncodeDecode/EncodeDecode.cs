using System;
using System.Text;

class EncodeDecode
{
    static string EncodeDecodeMsg(string msgEncodeDecode, string chiper)
    {
        StringBuilder Encoded_Decoded = new StringBuilder();
        for (int indexOne = 0; indexOne < msgEncodeDecode.Length; indexOne += chiper.Length)
        {
            for (int indexTwo = 0; indexTwo < chiper.Length; indexTwo++)
            {
                if (indexOne + indexTwo > msgEncodeDecode.Length - 1)
                {
                    break;
                }
                char temp = (char)(msgEncodeDecode[indexOne + indexTwo] ^ chiper[indexTwo]);
                Encoded_Decoded.Append(temp);
            }
        }
        return Encoded_Decoded.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter your text to encode/decode below:");
        string msgToEncodeDecode = Console.ReadLine();
        Console.WriteLine("Enter your chifer below:");
        string chiper = Console.ReadLine();
        Console.WriteLine("Encoded/Decoded text:");
        string result = EncodeDecodeMsg(msgToEncodeDecode, chiper);
        Console.WriteLine(result);
        Console.WriteLine();
        result = EncodeDecodeMsg(result, chiper);
        Console.WriteLine(result);
      
        
        
    }
}
