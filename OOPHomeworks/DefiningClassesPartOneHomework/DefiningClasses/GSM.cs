namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        public const decimal pricePerMin = 0.37M;

        private string manufacturer;
        private string model;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string manufacturer, string model)
            : this(manufacturer, model, 0, null, new Battery(), new Display()) { }

        public GSM(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty.");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Owner cannot be null, empty or less than two symbols.");
                }

                this.owner = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return new GSM("Apple", "iPhone 4S"); }
        }

        public string CallHistory
        {
            get
            {
                return string.Join("\n", this.callHistory.Select(x => x.ToString()));
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendLine(new string('*', 15) + "Phone INFO" + new string('*', 15));
            info.AppendFormat("Manifacturer: {0} Model: {1}", Manufacturer, Model);
            info.AppendFormat("\nPrice: {0:C} \nOwner: {1}", Price, Owner);
            info.AppendLine();
            info.AppendLine(new string('*', 15) + "Battery INFO" + new string('*', 15));
            info.AppendFormat("Model: {0} Hours idle: {1} Hours talk: {2} Type: {3}", battery.Model, battery.HoursIdle, battery.HoursTalk, battery.BatType);
            info.AppendLine();
            info.AppendLine(new string('*', 15) + "Display INFO" + new string('*', 15));
            info.AppendFormat("Size: {0} Colors: {1}", display.Size, display.Colors);

            return info.ToString();
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall()
        {
            ulong maxCallDuration = 0;
            int index = 0;
            foreach (var call in this.callHistory)
            {
                if (call.CallDuration > maxCallDuration)
                {
                    maxCallDuration = call.CallDuration;
                    index = callHistory.IndexOf(call);
                }
            }
            this.callHistory.RemoveAt(index);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public string PriceOfCalls()
        {
            decimal totalDuration = 0;
            decimal result = 0;

            foreach (var call in this.callHistory)
            {
                totalDuration += call.CallDuration;
            }

            result = totalDuration / 60;
            result *= pricePerMin;
            string total = string.Format("Toatal price: {0:F2}", result);
            return total;
        }

    }
}

