namespace School
{
    using System;

    public class School
    {
        private static int uniqueNumber = 10000;
        
        public static int UniqueNumber
        {
            get
            {
                return uniqueNumber;
            }

            set
            {
                if(value < 10000 || 99999 < value)
                {
                    throw new ArgumentOutOfRangeException("The unique number must be between 10000 and 99999!");
                }

                uniqueNumber = value;
            }
        }
    }
}
