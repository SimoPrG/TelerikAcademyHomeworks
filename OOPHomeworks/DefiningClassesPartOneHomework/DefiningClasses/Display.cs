namespace DefiningClasses
{
    using System;

    public class Display
    {
        private float size;
        private uint colors;

        public Display() : this(0, 0) { }

        public Display(float size, uint colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public float Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The size of displey cannot be less than zero.");
                }

                this.size = value;
            }
        }

        public uint Colors
        {
            get { return this.colors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The colors of displey cannot be less than zero.");
                }

                this.colors = value;
            }
        }
    }
}
