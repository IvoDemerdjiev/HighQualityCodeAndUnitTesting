namespace SchoolAndCourses
{
    using System;

    public class Student
    {
        private string name;

        private readonly int uniqueNumber;

        public Student(string name)
        {
            this.Name = name;
            this.uniqueNumber =School.UniqueNumber++;
        }

        public string Name
        {
            get
            {
                return this.name;
            } 
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public int UniqueNumber { get { return this.uniqueNumber; } }
    }
}
