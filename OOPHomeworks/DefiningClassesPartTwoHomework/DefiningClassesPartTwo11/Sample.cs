namespace DefiningClassesPartTwo11
{
    using System;

    [Version("2.11")]

    public class Sample
    {
        static void Main()
        {
            {
                Type type = typeof(Sample);
                object[] attr = type.GetCustomAttributes(false);

                foreach (VersionAttribute item in attr)
                {
                    Console.WriteLine(item.Version);
                }
            }
        }
    }
}
