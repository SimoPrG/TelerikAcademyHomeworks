namespace School.Test
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class StudentTests
    {
        private Student validTestStudent = new Student("Ivan Ivanov");

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfNameIsNull()
        {
            Student testStudent = new Student(null);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfNameIsEmpty()
        {
            Student testStudent = new Student(string.Empty);
        }

        [TestMethod]
        public void StudentShouldBeCreatedWithExpectedPropertiesWhenValidArgumentsArePassed()
        {
            Student testStudent = validTestStudent;
            Assert.AreEqual("Ivan Ivanov", testStudent.Name);
            Assert.AreEqual(0, testStudent.Courses.Count, "Initially courses is an empty list");
            Assert.IsTrue(10000 <= testStudent.Number && testStudent.Number <= 99999, "Unique number must be in the range [10000, 99999]");
        }

        [TestMethod]
        public void StudentUniqueNumberMustBeDifferentForAllDifferentInstances()
        {
            int testStudentsCount = 1000;
            int[] uniqueStudentNumbers = new int[testStudentsCount];
            for (int i = 0; i < testStudentsCount; i++)
            {
                Student testStudent = new Student("Ivan Ivanov");
                uniqueStudentNumbers[i] = testStudent.Number;
            }
            Array.Sort(uniqueStudentNumbers);
            for (int i = 1; i < uniqueStudentNumbers.Length; i++)
            {
                Assert.AreNotEqual(
                    uniqueStudentNumbers[i],
                    uniqueStudentNumbers[i - 1],
                    "Student numbers should be unique");
            }
        }

        [TestMethod]
        public void WhenStudentSignsACourseTheCourseShouldAppearInCoursesListAndStudentInCoursesStudentList()
        {
            Student testStudent = this.validTestStudent;
            Course testCourse = new Course("TestCourse");
            testStudent.AddCourse(testCourse);
            Assert.IsTrue(testStudent.Courses.Contains(testCourse), "Signed course should be added to the list of courses");
            Assert.IsTrue(testCourse.StudentsList.Contains(testStudent), "Signed student should be added to the list of students");
        }

        [TestMethod]
        public void WhenStudentUnsignsACourseTheCourseShouldBeRemovedFromTheCoursesListAndTheStudentFromTheCourseStudentList()
        {
            Student testStudent = this.validTestStudent;
            Course testCourse = new Course("TestCourse");
            testStudent.AddCourse(testCourse);
            Assert.IsTrue(testStudent.Courses.Contains(testCourse), "Signed course should be added to the list of courses");
            testStudent.RemoveCourse(testCourse);
            Assert.IsFalse(testStudent.Courses.Contains(testCourse), "Unsigned course should be removed from the list of courses");
            Assert.IsFalse(testCourse.StudentsList.Contains(testStudent), "Unsigned student should be removed from the list of students");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowAnArgumentNullExceptionWhenNullIsPassedToTheAddCourseMethod()
        {
            Student testStudent = validTestStudent;
            testStudent.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowAnArgumentNullExceptionWhenNullIsPassedToTheRemoveCourseMethod()
        {
            Student testStudent = validTestStudent;
            testStudent.RemoveCourse(null);
        }
    }
}
