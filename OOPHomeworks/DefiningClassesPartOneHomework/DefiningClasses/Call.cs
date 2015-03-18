namespace DefiningClasses
{
    public class Call
    {
        private string dateAndTime;
        private string dialledNumber;
        private ulong callDuration;

        public Call() : this("1.1.2000 00:00:00", "(unknown number)", 0) { }
        
        public Call(string dateAndTime, string dialledNumber, ulong callDuration)
        {
            this.dateAndTime = dateAndTime;
            this.dialledNumber = dialledNumber;
            this.callDuration = callDuration;
        }

        public string DateAndTime
        {
            get { return this.dateAndTime; }
        }

        public string DialledNumber
        {
            get { return this.dialledNumber; }
        }

        public ulong CallDuration
        {
            get { return this.callDuration; }
        }

        public override string ToString()
        {
            string result = string.Format("{0} [{1}] {2}", this.dateAndTime, this.dialledNumber, this.callDuration);
            return result;
        }
    }
}
