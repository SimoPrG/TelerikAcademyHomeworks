//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using IEnumerableExtensions.Extensions;

    class IEnumExt
    {
        static void Main()
        {
            var list = new List<int> { 2, 8, 15, 9, 52, 98, 11 };

            Console.WriteLine("Sum of elements in collection: " + list.Sum());
            Console.WriteLine("Product of elements in collection: " + list.Product());
            Console.WriteLine("Max element in collection: " + list.Max());
            Console.WriteLine("Min element in collection: " + list.Min());
            Console.WriteLine("Avarage sum of elements in collection: " + list.Avarage());
        }
    }
}
