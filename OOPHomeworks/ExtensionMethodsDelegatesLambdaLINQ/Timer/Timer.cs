namespace Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        private int seconds;
        private byte ticks;
        private TimerDelegate tDelegate;

        public Timer(int seconds, byte ticks, TimerDelegate tDelegate)
        {
            this.seconds = seconds;
            this.ticks = ticks;
            this.tDelegate = tDelegate;
        }

        public int Interval
        {
            get { return this.seconds; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.seconds = value;
            }
        }

        public byte Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.ticks = value;
            }
        }

        public TimerDelegate Delegate
        {
            get { return this.tDelegate; }
            set { this.tDelegate = value; }
        }

        public void Run()
        {
            while (ticks > 0)
            {
                Thread.Sleep(this.seconds * 1000);
                --ticks;
                tDelegate();
            }
        }
    }
}
