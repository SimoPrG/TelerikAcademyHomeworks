namespace BittArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set 
            {
                if (value < 0 || value > Int64.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.number = value;
            }
        }

        public int[] BinNumber 
        { 
            get
            {
                return Convert(this.Number);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position!");
                }
                return BinNumber[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < BinNumber.Length; i++)
            {
                yield return BinNumber[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static int[] Convert(ulong num)
        {
            int[] result = new int[64];
            int counter = 63;

            while (num > 0)
            {
                result[counter] = (int)num % 2;
                num /= 2;
                counter--;
            }

            if (counter >= 0)
            {
                for (int i = counter; i >= 0; i--)
                {
                    result[i] = 0;
                }
            }
            return result;
        }

        public override bool Equals(object num)
        {
            var number = (BitArray64)num;

            for (int i = 0; i < BinNumber.Length; i++)
            {
                if (this.BinNumber[i] != number[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.BinNumber[0] ^ this.Number.GetHashCode() ^ this.BinNumber[63];
        }

        public override string ToString()
        {
            return string.Join("", BinNumber);
        }

        public static bool operator ==(BitArray64 firstNum, BitArray64 secondNum)
        {
            for (int i = 0; i < firstNum.BinNumber.Length; i++)
            {
                if (firstNum[i] != secondNum[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(BitArray64 firstNum, BitArray64 secondNum)
        {
            for (int i = 0; i < firstNum.BinNumber.Length; i++)
            {
                if (firstNum[i] != secondNum[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
