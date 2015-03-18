namespace DefiningClasses
{
    using System;
    using DefiningClasses;

    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            //creating GSMs
            var iPhone6 = new GSM("Apple", "iPhone 6");
            var galaxyS6 = new GSM("Samsung", "Galaxy S 6");
            var g3 = new GSM("LG", "G3");

            //adding calls on each GSM's call history
            iPhone6.AddCall(new Call("21.05.2015 15:36:12", "+359888456891", 154));
            iPhone6.AddCall(new Call("22.05.2015 18:38:12", "+359878475896", 35));
            iPhone6.AddCall(new Call("25.05.2015 13:34:12", "+359898475126", 75));

            galaxyS6.AddCall(new Call());

            g3.AddCall(new Call("21.07.2015 15:36:12", "+359888476891", 78));
            g3.AddCall(new Call("7.08.2015 10:25:22", "+359876554015", 45));

            //printing call history and total price of calls
            Console.WriteLine(Environment.NewLine + iPhone6.Model);
            Console.WriteLine(iPhone6.CallHistory);
            Console.WriteLine(iPhone6.PriceOfCalls());

            Console.WriteLine(Environment.NewLine + galaxyS6.Model);
            Console.WriteLine(galaxyS6.CallHistory);
            Console.WriteLine(galaxyS6.PriceOfCalls());

            Console.WriteLine(Environment.NewLine + g3.Model);
            Console.WriteLine(g3.CallHistory);
            Console.WriteLine(g3.PriceOfCalls());

            //deleting call with maximal duration and printing call history and total price of calls
            iPhone6.DeleteCall();
            Console.WriteLine(Environment.NewLine + iPhone6.Model);
            Console.WriteLine(iPhone6.CallHistory);
            Console.WriteLine(iPhone6.PriceOfCalls());

            g3.DeleteCall();
            Console.WriteLine(Environment.NewLine + g3.Model);
            Console.WriteLine(g3.CallHistory);
            Console.WriteLine(g3.PriceOfCalls());

            //clearin call histrory
            iPhone6.ClearHistory();
            Console.WriteLine(Environment.NewLine + iPhone6.Model);
            Console.WriteLine(iPhone6.CallHistory);
            Console.WriteLine(iPhone6.PriceOfCalls());

            g3.ClearHistory();
            Console.WriteLine(Environment.NewLine + g3.Model);
            Console.WriteLine(g3.CallHistory);
            Console.WriteLine(g3.PriceOfCalls());
        }
    }
}
