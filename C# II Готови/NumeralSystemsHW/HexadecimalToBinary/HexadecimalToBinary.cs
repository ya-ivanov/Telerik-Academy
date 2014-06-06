using System;

class HexadecimalToBinary
{
    static string AddBinDigits(string hexNum)
    {
        string result = "";
        for (int move = 0; move < hexNum.Length; move++)
        {
            if (hexNum.Substring(move, 1) == "0")
                result += "0000";
            else if (hexNum.Substring(move, 1) == "1")
                result += "0001";
            else if (hexNum.Substring(move, 1) == "2")
                result += "0010";
            else if (hexNum.Substring(move, 1) == "3")
                result += "0011";
            else if (hexNum.Substring(move, 1) == "4")
                result += "0100";
            else if (hexNum.Substring(move, 1) == "5")
                result += "0101";
            else if (hexNum.Substring(move, 1) == "6")
                result += "0110";
            else if (hexNum.Substring(move, 1) == "7")
                result += "0111";
            else if (hexNum.Substring(move, 1) == "8")
                result += "1000";
            else if (hexNum.Substring(move, 1) == "9")
                result += "1001";
            else if (hexNum.Substring(move, 1).ToUpper() == "A")
                result += "1010";
            else if (hexNum.Substring(move, 1).ToUpper() == "B")
                result += "1011";
            else if (hexNum.Substring(move, 1).ToUpper() == "C")
                result += "1100";
            else if (hexNum.Substring(move, 1).ToUpper() == "D")
                result += "1101";
            else if (hexNum.Substring(move, 1).ToUpper() == "E")
                result += "1110";
            else if (hexNum.Substring(move, 1).ToUpper() == "F")
                result += "1111";
            else if (hexNum.Substring(move, 1).ToUpper() == "")
                result += "";
        }
        while (result.StartsWith("0"))
        {
            result = result.Remove(0, 1);
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter your hexadecimal number below:");
        string hex = Console.ReadLine();
        string result = AddBinDigits(hex);
        Console.WriteLine("The representation in binary: {0}.", result);
    }

}

