namespace SchoolAndCourses
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public int Count { get { return this.students.Count; } }

        public void studentJoins(Student student)
        {
            if (this.students.Count == 30)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.students.Add(student);
        }

        public void studentLeaves(Student student)
        {
    
            if (this.students.Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.students.Remove(student);
        }
    }
}
