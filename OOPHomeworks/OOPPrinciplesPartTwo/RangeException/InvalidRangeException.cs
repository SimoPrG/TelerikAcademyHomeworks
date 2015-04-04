namespace RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException where T : IComparable
    {
        public InvalidRangeException(string msg, T start, T end, Exception ex)
            : base(string.Format("{0}\nIt should be in range [{1} to {2}]",msg, start, end), ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end) : this(msg, start, end, null) { }

        public InvalidRangeException(T start, T end) : this(null, start, end, null) { }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
