using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    internal class Enrollment
    {
        private DateTime dateEnrolled;
        private string grade;
        private string semester;

        //Property Assessor Methods:
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; } // Aggregation

        // Aggregation
        private Subject subject; // Aggregation relationship, an Enrollment has a Subject

        //constants for defaults

        static readonly DateTime DEF_DATE_ENROLLED = DateTime.MinValue;
        const string DEF_GRADE = "Not Graded";
        const string DEF_SEMESTER = "Unknown";

        // Static Variables
        private static int totalEnrollments = 0; //  static variable for total number of Enrollments 


        // No-argument constructor 
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {
        }

        // All-argument constructor
        public Enrollment(DateTime dateEnrolled, string grade, string semester)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
            totalEnrollments++; // Increment static variable
        }

        // Static Method
        public static int GetTotalEnrollments()
        {
            //get
            return totalEnrollments; // Returns the number of Enrollment instances 
        }



        //ToSTring 

        public override string ToString()
        {
            return "Date Enrolled: " + DateEnrolled + "Grade: " + Grade + "Semester: " + Semester + "Subject: " + Subject;

        }

    }


}
