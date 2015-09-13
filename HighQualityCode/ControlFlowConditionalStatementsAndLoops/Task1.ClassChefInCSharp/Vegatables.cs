namespace Task1.ClassChefInCSharp
{
    public class Vegatables
    {
        public Vegatables()
        {
            this.IsPeeled = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }

        public void Cook ()
        {
            this.IsPeeled = true;
            this.IsRotten = true;
        }
    }
}
