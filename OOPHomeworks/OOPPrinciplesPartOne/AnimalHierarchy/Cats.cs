namespace AnimalHierarchy
{
    public class Cats : Animal, ISound
    {
        public Cats(string name, byte age, Sex sex)
            : base(name, age, sex)
        {

        }

        public string Sound
        {
            get { return "Myau, myau, myau!"; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1} Sex: {2}");
        }
    }
}
