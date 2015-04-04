namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;

    public class DefiningClasses
    {
        static void Main()
        {
            var list = new GenericList<int>();


            //var list = new List<int>();

            list.Add(15);
            list.Add(12);
            list.Add(48);
            list.Add(154);
           
            //list.Insert(4, 77);

            list.Add(13);
            list.Add(44);
            list.Add(78);
            list.Add(99);

            list.Insert(7, 33);

            Console.WriteLine(list);
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
        }
    }
}
