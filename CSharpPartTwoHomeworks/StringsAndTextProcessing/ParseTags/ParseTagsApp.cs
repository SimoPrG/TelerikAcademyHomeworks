//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Threading;
using System.Globalization;

class ParseTagsApp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string separatorOne = "<upcase>";
        string separatorTwo = "</upcase>";

        int indexStrat = text.IndexOf(separatorOne);
        int indexStop = text.IndexOf(separatorTwo);

       
        while (indexStrat != -1)
        {
            string subStr = text.Substring(indexStrat + separatorOne.Length, indexStop - (indexStrat + separatorOne.Length));

            text = text.Replace(subStr, subStr.ToUpper()); 

            indexStrat = text.IndexOf(separatorOne, indexStrat + 1);
            indexStop = text.IndexOf(separatorTwo, indexStop + 1);
        }

        text = text.Replace(separatorOne, string.Empty).Replace(separatorTwo, string.Empty);

        Console.WriteLine(text);
    }
}

