namespace School.Test
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolAndCourses;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Courses_ConstructorWorkingCorrectly()
        {
            var course = new Course();
            Assert.IsNotNull(course);
        }

        [TestMethod]
        public void Courses_CanAddCorrectly()
        {
            var course = new Course();
            var initialStudents = course.Count;
            var studentToAdd = new Student("Ivan");
            course.studentJoins(studentToAdd);

            Assert.AreEqual(initialStudents + 1, course.Count);
        }

        [TestMethod]
        public void Courses_CanLeaveCorrectly()
        {
            var course = new Course();
            var initialStudents = course.Count;
            var studentToLeave = new Student("Ivan");
            course.studentJoins(studentToLeave);

            Assert.AreEqual(initialStudents, course.Count - 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_ShouldThrowAnApplicationExceptionWhenNumberOfSigned_StudentsExceedsTheLimit()
        {
            Course testCourse = new Course();
            for (int i = 0; i <= 30; i++)
            {
                Student testStudent = new Student("Ivan");
                testCourse.studentJoins(testStudent);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseShouldThrowAnApplicationExceptionWhenNumberOfSignedStudentsExceedsTheLimit()
        {
            Course testCourse = new Course();
            for (int i = 30; i >= 0; i--)
            {
                Student testStudent = new Student("Ivan");
                testCourse.studentLeaves(testStudent);
            }
        }

    }
}
