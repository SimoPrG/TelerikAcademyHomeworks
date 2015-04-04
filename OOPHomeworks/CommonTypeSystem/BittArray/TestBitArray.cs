//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BittArray
{
    using System;

    public class TestBitArray
    {
        public static void Main()
        {
            var num = new BitArray64(45U);
            var otherNum = new BitArray64(41U);
            var anotherNum = new BitArray64(45U);

            Console.WriteLine(num);
            Console.WriteLine(num[61]);
            Console.WriteLine(num.Equals(otherNum));
            Console.WriteLine(num.GetHashCode());
            Console.WriteLine(otherNum.GetHashCode());
            Console.WriteLine(otherNum);
            Console.WriteLine(num == otherNum);
            Console.WriteLine(num != otherNum);
            Console.WriteLine(num == anotherNum);
        }
    }
}
