//Problem 12.** Falling Rocks

//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public char sym;
    public ConsoleColor color;
}
class Rocks
{
    static void PrintOnPosition(int x, int y, char sym, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(sym);
    }
    static void PrintStringOnPosition(int x, int y, string info, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(info);
    }
    static void Main()
    {
        int playField = 15;
        int livesCounter = 5;
        Console.BufferHeight = Console.WindowHeight = 15;
        Console.BufferWidth = Console.WindowWidth = 40;
        Object dwarf = new Object();
        dwarf.x = 7;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.sym = '0';
        dwarf.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Object> rocks = new List<Object>();


        while (true)
        {
            string rockSymbol = "^@*&+%$#!.;-";
            bool hitted = false;
            {
                Object newRock = new Object();
                newRock.color = ConsoleColor.Magenta;
                newRock.x = randomGenerator.Next(0, playField + 1);
                newRock.y = 0;
                newRock.sym = rockSymbol[randomGenerator.Next(1, 12)];
                rocks.Add(newRock);
            }

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 <= playField)
                    {
                        dwarf.x++;
                    }
                }
            }
            List<Object> newList = new List<Object>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.sym = oldRock.sym;
                newRock.color = oldRock.color;
                if (newRock.y == dwarf.y && newRock.x == dwarf.x)
                {
                    livesCounter--;
                    hitted = true;
                    if (livesCounter <= 0)
                    {
                        PrintStringOnPosition(20, 5, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(20, 6, "Press [enter] to exit...", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            Console.Clear();
            if (hitted)
            {
                rocks.Clear();
                PrintStringOnPosition(dwarf.x, dwarf.y, "(*)", ConsoleColor.Red);
            }
            else
            {
                PrintStringOnPosition(dwarf.x, dwarf.y, "(0)", dwarf.color);
            }
            foreach (Object rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.sym, rock.color);
            }
            PrintStringOnPosition(20, 5, "Lives: " + livesCounter, ConsoleColor.Cyan);
            Thread.Sleep(150);
        }
    }
}
