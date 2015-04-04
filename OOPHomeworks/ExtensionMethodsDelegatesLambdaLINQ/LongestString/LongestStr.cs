//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestStr
    {
        static void Main()
        {
            var stringArr = new string[] { "telerik academy", "delegate", "cSharp", ".net" };

            Console.WriteLine("The longest string: {0}", GetLongestString(stringArr));
        }

        public static string GetLongestString(string[] arr)
        {
            var sortedArr =
                            from str in arr
                            orderby str.Length
                            select str;

            return sortedArr.LastOrDefault().ToString();
        }
    }
}
