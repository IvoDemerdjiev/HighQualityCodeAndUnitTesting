namespace School.Test
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolAndCourses;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void School_ShouldReturnCorrectUniqueId_WhenItIsSetCorrectly()
        {
            School.UniqueNumber = 15000;

            Assert.AreEqual(15000, School.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void School_ShouldReturnCorrectUniqueId_WhenItIsLessThan10000()
        {
            School.UniqueNumber = 9999;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void School_ShouldReturnCorrectUniqueId_WhenItIsGreaterThan99999()
        {
            School.UniqueNumber = 1000000;

        }
    }
}
