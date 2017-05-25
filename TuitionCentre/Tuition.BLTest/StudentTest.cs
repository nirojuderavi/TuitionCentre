using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuitionCentre.BL;

namespace Tuition.BLTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void FullNameTestValidation()
        {

            //Arrange
            Student student = new Student();
            student.FirstName = "Niro";
            student.LastName = "Ravi";
            string expected = "Niro Ravi";
            //Act

            string actual = student.FullName;

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {

            //Arrange
            Student student = new Student();
            
            student.LastName = "Ravi";
            string expected = "Ravi";
            //Act

            string actual = student.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {

            //Arrange
            Student student = new Student();
            student.FirstName = "Niro";
            
            string expected = "Niro";
            //Act

            string actual = student.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InstanceCount()
        {

            //Arrange
            Student student1 = new Student();
            student1.FirstName = "Niro";
            Student.InstanceCount++;

            Student student2 = new Student();
            student2.FirstName = "Anthony";
            Student.InstanceCount++;

            Student student3 = new Student();
            student3.FirstName = "Nili";
            Student.InstanceCount++;
            //Act

            int actual = Student.InstanceCount;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {

            //Arrange

            var student = new Student();
            student.LastName = "Ravi";
            student.StudentEmail = "niroravio@example.com";
            var expected = true;

            //Act

            var actual = student.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInValid()
        {

            //Arrange

            var student = new Student();
            student.LastName = "Ravi";
            var expected = false;

            //Act

            var actual = student.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
