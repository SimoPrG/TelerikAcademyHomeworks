namespace DefiningClasses
{
    using System;

    public class GSMTest
    {
        public static void Main()
        {
            //creating GSMs
            var iPhone6 = new GSM("Apple", "IPhone 6", 1499.99M, "Tim Cook", 
                new Battery("Integrated", 100F, 10F, BatteryType.LiIon), 
                new Display(4.7F, 16000000));
            var galaxyS6 = new GSM("Samsung", "Galaxy S6");

            //adding phones in an array
            GSM[] phones = { iPhone6, galaxyS6 };

            //printing information of each phone
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine(new string('-', 70));
            }

            //printing information of iPhone4s
            Console.WriteLine(GSM.IPhone4S);

            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
