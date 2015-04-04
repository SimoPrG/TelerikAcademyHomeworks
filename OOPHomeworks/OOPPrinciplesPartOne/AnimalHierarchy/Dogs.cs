namespace AnimalHierarchy
{
    public class Dogs : Animal, ISound
    {
        public Dogs(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
                
        }

        public string Sound
        {
            get { return "Bau bau bau!"; }
        }
    }
}
