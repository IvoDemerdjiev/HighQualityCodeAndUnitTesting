namespace School.Test
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolAndCourses;

    [TestClass]
    public class StudentsTest
    {
        [TestMethod]
        public void Student_ConstructorIsWorkingCorrectly_StudentName()
        {
            var name = "Ivan";

            var student = new Student(name);

            Assert.AreSame(name, student.Name);
        }

        [TestMethod]
        public void Student_ConstructorIsWorking_EntityIsNOtNull()
        {
            var name = "Ivan";

            var student = new Student(name);

            Assert.IsNotNull(student);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentOutOfRangeException))]
        public void ArgumentExceptionShouldBeThrownIfFirstNameIsNull()
        {
            Student testStudent = new Student(" ");
        }

        [TestMethod]
        public void Student_UniqueNumberIsInRange()
        {
            var name = "Ivan";

            var student = new Student(name);

            Assert.IsTrue(student.UniqueNumber >= 10000 && student.UniqueNumber <= 99999);
        }
    }
}
