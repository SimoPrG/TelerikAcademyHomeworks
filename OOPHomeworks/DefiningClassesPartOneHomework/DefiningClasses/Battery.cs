namespace DefiningClasses
{
    using System;

    public class Battery
    {
        private string model;
        private float hoursIdle;
        private float hoursTalk;
        private BatteryType batType;

        public Battery() : this(null, 0, 0, BatteryType.Unknown) { }

        public Battery(string model, float hoursIdle, float hoursTalk, BatteryType batType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batType = batType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be null or empty.");
                }

                this.model = value;
            }
        }

        public float HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("Hours idle cannot be less than 0 or bigger than 10000.");
                }

                this.hoursIdle = value;
            }
        }

        public float HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("Hours talk cannot be less than 0 or bigger than 10000.");
                }

                this.hoursTalk = value;
            }
        }

        public string BatType
        {
            get { return this.batType.ToString(); }
        }
    }
}
