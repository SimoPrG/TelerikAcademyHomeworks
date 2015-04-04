namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, ICommentable
    {
        public Teacher(string name)
            : base(name) 
        {
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines { get; private set; }

        public string Comment { get; set; }

        public Discipline Discipline { get; set; }

        public void AddDisciplines(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDisciplines(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public string GetDisciplines()
        {
            var result = new StringBuilder();

            foreach (var discipline in Disciplines)
            {
                result.AppendLine(discipline.ToString());
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
