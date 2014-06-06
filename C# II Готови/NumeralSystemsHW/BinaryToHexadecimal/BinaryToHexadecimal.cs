using System;
using System.Text;

class BinaryToHexadecimal
{
    static string BinToHex(string binaryNum)
    {
        StringBuilder result = new StringBuilder(binaryNum.Length / 9);
        int Len = binaryNum.Length % 8;
        if (Len != 0)
        {
            binaryNum = binaryNum.PadLeft(((binaryNum.Length / 8) + 1) * 8, '0');
        }

        for (int i = 0; i < binaryNum.Length; i += 8)
        {
            string eightBits = binaryNum.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
        }

        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter your binary number bellow:");
        string result = Console.ReadLine();
        result = BinToHex(result);
        Console.WriteLine("Binary representation:");
        Console.WriteLine(result);
    }
}
