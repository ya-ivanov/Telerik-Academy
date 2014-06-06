using System;

class Standart52CardDeck
{
    static void Main()
    {
        int CardNum = 1;
        string type = "Clubs";
        A: for (; CardNum < 14; CardNum++)
        {
            switch (CardNum)
            {
                case 1:
                    Console.WriteLine("Ace of {0} ", type);
                    break;
                case 2:
                    Console.WriteLine("Two of {0} ", type);
                    break;
                case 3:
                    Console.WriteLine("Three of {0} ", type);
                    break;
                case 4:
                    Console.WriteLine("Four of {0} ", type);
                    break;
                case 5:
                    Console.WriteLine("Five of {0} ", type);
                    break;
                case 6:
                    Console.WriteLine("Six of {0} ", type);
                    break;
                case 7:
                    Console.WriteLine("Seven of {0} ", type);
                    break;
                case 8:
                    Console.WriteLine("Eight of {0} ", type);
                    break;
                case 9:
                    Console.WriteLine("Nine of {0} ", type);
                    break;
                case 10:
                    Console.WriteLine("Ten of {0} ", type);
                    break;
                case 11:
                    Console.WriteLine("Jack of {0} ", type);
                    break;
                case 12:
                    Console.WriteLine("Queen of {0} ", type);
                    break;
                case 13:
                    Console.WriteLine("King of {0} ", type);
                    if (type == "Clubs")
                    {
                        CardNum = 1;
                        type = "Diamonds";
                        Console.WriteLine("_____________________");
                        goto A;
                    }
                    if (type == "Diamonds")
                    {
                        CardNum = 1;
                        type = "Hearts";
                        Console.WriteLine("_____________________");
                        goto A;
                    }
                    if (type == "Hearts")
                    {
                        Console.WriteLine("_____________________");
                        break;
                    }
                    break;
               
            }
            
            
        }
    }
}

