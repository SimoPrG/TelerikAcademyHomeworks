//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:

//input	                                                                output

//<p>Please visit <a href="http://academy.telerik.                      <p>Please visit [URL=http://academy.telerik. com]our 
//com">our site</a> to choose a training course. Also                   site[/URL] to choose a training course. Also visit 
//visit <a href="www.devbg.org">our forum</a> to discuss                [URL=www.devbg.org]our forum[/URL] to discuss the 
//the courses.</p>                                                      courses.</p>

using System;
using System.Text.RegularExpressions;


class ReplaceTagsApp
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        Console.WriteLine(Regex.Replace(input, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
    }
}

