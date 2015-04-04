//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Timer
{
    using System;
    using System.Threading;

    public class TimerApp
    {
        static void Main()
        {
            var t = new Timer(2, 10, delegate() { Console.WriteLine("tick - tack"); });
            Thread tThread = new Thread(new ThreadStart(t.Run));
            tThread.Start();
        }
    }
}
