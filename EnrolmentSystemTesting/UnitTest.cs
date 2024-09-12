using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EnrolmentSystem;


namespace EnrolmentSystemTesting
{
    [TestFixture]
    public class UnitTest
    {
        Student[] studentsArray;


        Student student5 = new Student("105", "Python Intermediate", new DateTime(), new Enrollment());
        Student student6 = new Student("106", "JAVA Advanced", new DateTime(), new Enrollment());
        Student student7 = new Student("107", "EWD", new DateTime(), new Enrollment());
        Student student8 = new Student("108", "Leadership and Facilitate", new DateTime(), new Enrollment());
        Student student9 = new Student("109", "Workplace Cyber Security", new DateTime(), new Enrollment());
        Student student10 = new Student("110", "Manage client problems", new DateTime(), new Enrollment());
        Student student11 = new Student("111", "IP Ethics and Policy", new DateTime(), new Enrollment());
        Student student12 = new Student("112", "Creating REST APIs", new DateTime(), new Enrollment());
        Student student13 = new Student("113", "Build User Interface", new DateTime(), new Enrollment());
        Student student14 = new Student("114", "Project Management", new DateTime(), new Enrollment());
        Student student15 = new Student("115", "Database", new DateTime(), new Enrollment());


        [SetUp]
        public void setup()
        {
            studentsArray = new Student[] { student5, student7, student9, student6, student11, student10, student13, student14, student13, student8 };

        }

        [Test]
        public void StudentInArray()
        {
            Assert.AreEqual(0, Utility.LinearSearch(studentsArray, student5)); //student found 


        }

        [Test]
        public void StudentNotInArray()
        {
            Assert.AreEqual(-1, Utility.LinearSearch(studentsArray, student15)); //student not found 


        }

        [Test]
        public void BinarySearchArray()
        {
            Utility.BubbleSort_Ascending(studentsArray);
            Assert.AreEqual(-1, Utility.BinarySearchArray(studentsArray, student15)); //student not found 


        }
        [Test]
        public void BinarySearchFoundArray()
        {
            Utility.BubbleSort_Ascending(studentsArray);
            Assert.AreEqual(0, Utility.BinarySearchArray(studentsArray, student5)); //student found 



        }
    }
}