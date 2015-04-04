namespace RangeException
{
    using System;

    class RangeExceptionsTest
    {
        static DateTime startDate = new DateTime(1980, 1, 1);
        static DateTime endDate = new DateTime(2013, 12, 31);

        static void Main()
        {
            int[] simpleNums = { 95, 200};

            try
            {
                foreach (var simpleNum in simpleNums)
                {
                    if (simpleNum < 0 || simpleNum > 100)
                    {
                        throw new InvalidRangeException<int>("Invalid number!", 1, 100);
                    }
                    Console.WriteLine("Num is: {0}", simpleNum);
                }
                
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('*', 40));

            DateTime[] dates = { new DateTime(2012, 8, 15), new DateTime(2015, 7, 24) };

            try
            {
                foreach (var date in dates)
                {
                    if (date < startDate || date > endDate)
                    {
                        throw new InvalidRangeException<DateTime>("Invalid date!", startDate, endDate);
                    }
                    Console.WriteLine("Date is: {0}", date);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
