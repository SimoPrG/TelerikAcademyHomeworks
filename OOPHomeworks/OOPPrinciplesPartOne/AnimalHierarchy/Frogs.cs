namespace AnimalHierarchy
{
    public class Frogs : Animal, ISound
    {
        public Frogs(string name, byte age, Sex sex)
            : base(name, age, new Sex())
        {

        }

        public string Sound
        {
            get { return "Quaq, quaq, quaq!"; }
        }
    }
}
