using System;
using System.Runtime.Remoting.Messaging;

namespace EnrolmentSystem
{
    public class Student : Person, IComparable, IComparable<Student>
    {

        //private int studentID;
        //private string program;
        //private DateTime dateRegistered;

        //Property Assessor Methods:
        public string StudentID { get; set; }
        public string Program { set; get; }
        public DateTime DateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }  //Aggregation 



        //constants for defaults

        const string DEF_STUDENT_ID = "None provided";
        const string DEF_PROGRAM = "None provided";
        private static readonly DateTime DEFAULT_DATE = DateTime.MinValue;
        //private static Enrollment DEF_ENROLMENT = null; 


        // No-argument constructor

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEFAULT_DATE, new Enrollment())
        {
        }

        // All-argument constructor
        public Student(string studentID, string program, DateTime date, Enrollment enrollment)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = date;
            StudentEnrollment = enrollment;


        }
        /// <summary>
        /// Compares the StudentID of the current object with the StudentID of another Student object.
        /// </summary>
        /// <param name="obj">The object to compare with the current Student object.</param>
        /// <returns>True if the StudentID of both objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student student = (Student)obj;
            return this.StudentID == student.StudentID;
        }

        /// <summary>
        /// Generates a hash code for the current Student object based on its StudentID.
        /// </summary>
        /// <returns>An integer that represents the hash code for the current Student object.</returns>
        public override int GetHashCode()
        {
            // Using the hash code of the StudentID. 
            return base.GetHashCode() ^ this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Overloads the equality operator (==) to compare two Student objects based on their StudentID.
        /// </summary>
        /// <param name="student1">The first Student object to compare.</param>
        /// <param name="student2">The second Student object to compare.</param>
        /// <returns>True if the StudentID of both objects are equal; otherwise, false.</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            if (ReferenceEquals(student1, null))
                return ReferenceEquals(student2, null);

            return student1.Equals(student2);
        }

        /// <summary>
        /// Overloads the inequality operator (!=) to compare two Student objects based on their StudentID.
        /// </summary>
        /// <param name="student1">The first Student object to compare.</param>
        /// <param name="student2">The second Student object to compare.</param>
        /// <returns>True if the StudentID of both objects are not equal; otherwise, false.</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }

        /// <summary>
        /// Returns a string that represents the current Student object.
        /// </summary>
        /// <returns>A string that contains the StudentID, Program, and DateRegistered of the current Student object.</returns>
        public override string ToString()
        {
            return base.ToString() + "\nStudent ID: " + StudentID + "\nProgram: " + Program + "\nDate Registered : " + DateRegistered;
        }


        public static bool operator <(Student student1, Student student2)
        {
            return student1<(student2);
        }

        public static bool operator >(Student student1, Student student2)
        {
            return student1 > (student2);
        }

        public static bool operator >=(Student student1, Student student2)
        {
            return student1 >=(student2);
        }
        public static bool operator <=(Student student1, Student student2)
        {
            return student1 <=(student2);
        }

        /// <summary>
        /// Compares this Student object to another Student by their StudentID.
        /// </summary>
        /// <param name="other">The other Student object to compare with.</param>
        /// <returns>An integer indicating the relative order of the Student objects.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the other Student is null.</exception>

        public int CompareTo(Student other)
        {
            if (other == null)
                throw new ArgumentNullException("obj");
            return this.StudentID.CompareTo (other.StudentID);
        }
        /// <summary>
        /// Compares this Student object to another object by their StudentID.
        /// </summary>
        /// <param name="obj">The object to compare with, expected to be a Student.</param>
        /// <returns>An integer indicating the relative order of the objects.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided object is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the provided object is not a Student instance.</exception>








































        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected Student Instance", "obj");

            Student student = (Student)obj;
            return this.StudentID.CompareTo(student.StudentID);

        }
    }
}








