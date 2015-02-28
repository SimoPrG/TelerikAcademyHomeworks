//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol],
//[server] and [resource] elements.

//Example:

//      URL	                                                                Information
//      http://telerikacademy.com/Courses/Courses/Details/212	            [protocol] = http 
//                                                                          [server] = telerikacademy.com 
//                                                                          [resource] = /Courses/Courses/Details/212

using System;
using System.Text.RegularExpressions;

class URL
{
    static void Main()
    {
        string input = "http://telerikacademy.com/Courses/Courses/Details/212";
     
        var url = new Uri(input);

        string protokol = url.Scheme;
        string server = url.Host;
        string source = url.AbsolutePath;

        Console.WriteLine("[protokol] = {0} \n[server] = {1} \n[source] = {2}", protokol, server, source);
    }
}

