using System;
using Task1.ClassChefInCSharp;

namespace Task2.RefactorTheFollowingIfStatements
{
    class RefactorIfStatements
    {
        static void Main()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                bool notPeeled = !potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (notPeeled && notRotten)
                {
                    potato.Cook();
                }
            }


            const int MinX = 5;
            const int MaxX = 15;
            const int MinY = 5;
            const int MaxY = 15;

            int x = 7;
            int y = 8;

            bool shouldVisitCell = true;

            if (shouldVisitCell && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            System.Console.WriteLine("Visited");
        }

        public static bool IsInRange(int value, int min, int max)
        {
            bool isInRange = value >= min && value <= max;

            return isInRange;
        }
    }
}
