namespace SchoolClasses
{
    using System;

    public class Discipline : ICommentable
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;

        public Discipline(string name, int numOfLectures, int numOfExercises)
        {
            this.Name = name;
            this.numOfLectures = numOfLectures;
            this.NumOfExercises = numOfExercises;
        }

        public string Comment { get; set; }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid discipline's name!");
                }
                this.name = value;
            }
        }

        public int NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of lectures!");
                }
                this.numOfLectures = value;
            }
        }

        public int NumOfExercises
        {
            get
            {
                return this.numOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of exercises!");
                }
                this.numOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - Number of lectures: {1}, Number of exercises: {2}", this.Name, this.NumOfLectures, this.NumOfExercises);
        }
    }
}
