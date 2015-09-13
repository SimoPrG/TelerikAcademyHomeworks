namespace Task1.ClassChefInCSharp
{
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.ProductsInBowl = new List<Vegatables>();
        }

        public ICollection<Vegatables> ProductsInBowl { get; set; }

        public void Add (Vegatables vegatable)
        {
            this.ProductsInBowl.Add(vegatable);
        }
    }
}
