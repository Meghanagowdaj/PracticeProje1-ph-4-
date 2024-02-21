using PracticeProje1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProje1
{
    [TestFixture]
    public class Stud
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Megha";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Megha", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Tumkur(d) Kunigal";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Tumkur(d) Kunigal", studentAddress);
        }
    }
}
    