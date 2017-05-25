using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuitionCentre.BL;

namespace Tuition.BLTest
{
    [TestClass]
    public class StudentRepositoryTests
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            var studentrepo = new StudentRepository();

            var expected = new Student(1)
            {
                StudentEmail = "niroravi@test.com",
                FirstName = "Niro",
                LastName = "Ravi",
            };

            //Act
            var actual = studentrepo.Retrieve(1);

            //Assert

            Assert.AreEqual(expected.StudentId, actual.StudentId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.StudentEmail, actual.StudentEmail);


        }
    }
}
