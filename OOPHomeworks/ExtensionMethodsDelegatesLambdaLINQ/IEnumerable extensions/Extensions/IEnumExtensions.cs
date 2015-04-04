namespace IEnumerableExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            T result = (dynamic)0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            T result = (dynamic)1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T Max<T> (this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            T maxItem = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item > maxItem)
                {
                    maxItem = item;
                }
            }

            return maxItem;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            T minItem = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item < minItem)
                {
                    minItem = item;
                }
            }

            return minItem;
        }

        public static T Avarage<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            T result = (dynamic)0;
            var count = 0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
                count++;
            }

            result = result / (dynamic)count;
            return result;
        }
    }
}
