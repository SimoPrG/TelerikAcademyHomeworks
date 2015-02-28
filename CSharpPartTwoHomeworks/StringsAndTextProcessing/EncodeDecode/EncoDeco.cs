//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncoDeco
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.Write("Enter key (cipher): ");
        string key = Console.ReadLine();

        string encode = EncoDec(text, key);
        string decode = EncoDec(encode, key);

        Console.WriteLine(encode);
        Console.WriteLine(decode);
    }

    static string EncoDec(string text, string cipher)
    {
        var str = new StringBuilder();
        int j = 0;

        for (int i = 0; i < text.Length; i++)
        {
            str.Append((char)(text[i] ^ cipher[j]));
            j++;
            if (j == cipher.Length)
            {
                j = 0;
            }
        }
        return str.ToString();
    }
}
