using System;
using System.Xml.Linq;

namespace EnrolmentSystem
{
    internal class Student : Person 
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

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEFAULT_DATE,new Enrollment())
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

        // Override Equals method
        //This method compares the StudentID of the current object with the StudentID of another Student object. If they match, the two objects are considered equal.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student student = (Student)obj;
            return this.StudentID == student.StudentID;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            // Using the hash code of the StudentID. 
            return base.GetHashCode()^ this.StudentID.GetHashCode();
        }

        // Overload == operator
        public static bool operator ==(Student student1, Student student2)
        {
            if (ReferenceEquals(student1, null))
                return ReferenceEquals(student2, null);

            return student1.Equals(student2);
        }

        // Overload != operator
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }

        //ToSTring 

        public override string ToString()
        {
            return "Student ID: " + StudentID+ "\nProgram: " + Program + "\nDate Registered : " + DateRegistered;

        }

       
    }
}



    



