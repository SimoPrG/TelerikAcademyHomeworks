//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class DeckOfFiftyTwoCards
{
    static void Main()
    {
        string face = "";
        for (int i = 1; i <= 13; i++)
        {
            switch (i)
            {
                case 1: face = "2";
                    break;
                case 2: face = "3";
                    break;
                case 3: face = "4";
                    break;
                case 4: face = "5";
                    break;
                case 5: face = "6";
                    break;
                case 6: face = "7";
                    break;
                case 7: face = "8"; ;
                    break;
                case 8: face = "9";
                    break;
                case 9: face = "10";
                    break;
                case 10: face = "J";
                    break;
                case 11: face = "D";
                    break;
                case 12: face = "K";
                    break;
                case 13: face = "A";
                    break;
                default:
                    break;
            }
            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1: Console.Write("{0} of clubs, ", face);
                        break;
                    case 2: Console.Write("{0} of diamonds, ", face);
                        break;
                    case 3: Console.Write("{0} of hearts, ", face);
                        break;
                    case 4: Console.Write("{0} of spades. ", face);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

