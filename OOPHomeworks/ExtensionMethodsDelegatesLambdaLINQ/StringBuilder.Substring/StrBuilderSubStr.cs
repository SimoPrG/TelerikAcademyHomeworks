//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    using StringBuilderSubstring.Extensions;

    class StrBuilderSubStr
    {
        static void Main()
        {
            var text = new StringBuilder();
            text.Append("I am learning C sharp.");

            var subText = text.Substring(5, 8);

            Console.WriteLine(subText);
        }
    }
}
