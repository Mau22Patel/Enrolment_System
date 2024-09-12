using System;

namespace EnrolmentSystem
{
    public class Enrollment
    {
        //private DateTime dateEnrolled;
        //private string grade;
        //private string semester;

        //constants for defaults

        static readonly DateTime DEF_DATE_ENROLLED = DateTime.MinValue;
        const string DEF_GRADE = "Not Graded";
        const string DEF_SEMESTER = "Unknown";

        //Property Assessor Methods:
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject SubjectEnrollment { get; set; } // Aggregation relationship, an Enrollment has a Subject


        // No-argument constructor 
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject())
        {
        }

        // All-argument constructor
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            SubjectEnrollment = subject;

        }

        //ToSTring 

        public override string ToString()
        {
            return "Date Enrolled: " + DateEnrolled + "Grade: " + Grade + "Semester: " + Semester + "Subject Enrollment: " + SubjectEnrollment;

        }

    }


}
