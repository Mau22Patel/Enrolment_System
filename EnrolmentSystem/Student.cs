using System;

namespace EnrolmentSystem
{
    internal class Student : Person 
    {

        private int studentID;
        private string program;
        private DateTime dateRegistered;

        //Property Assessor Methods:
        public int StudentID { get; set; }
        public string Program { set; get; }
        public DateTime DateRegistered { get; set; }
        public Enrollment enrollment { get; set; }  //Aggregation 



        //constants for defaults

        const int DEF_STUDENT_ID =0;
        const string DEF_PROGRAM = "None provided";
        private static readonly DateTime DEFAULT_DATE = DateTime.MinValue;


        // No-argument constructor

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEFAULT_DATE)
        {
        }

        // All-argument constructor
        public Student(int StudentID, string Program, DateTime DateTime, Enrollment enrollment)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        

        }

        //ToSTring 

        public override string ToString()
        {
            return "Student ID: " + StudentID+ "Program: " + Program + "Date Registered : " + DateRegistered;

        }





    }
}


