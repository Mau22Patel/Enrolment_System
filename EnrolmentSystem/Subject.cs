namespace EnrolmentSystem
{
    internal class Subject
    {
        private string subjectCode;
        private string subjectName;
        private double cost;

        //Property Assessor Methods:
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        // Constants for default values
        const string DEF_SUBJECT_CODE = "None Provided";
        const string DEF_SUBJECT_NAME = "No Name Provided";
        const double DEF_COST = 0;

        // Static Variables
        private static int totalSubjects = 0;//  static variable for total number of subjects  

        // No-argument constructor 
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
        }

        // All-argument constructor
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
            totalSubjects++; //  static variable for total number of subjects  
        }
        // Static Method
        public static int GetTotalSubjects()

        {
            return totalSubjects; // Returns the total number of subjects created
        }

        //ToSTring 

        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + "Subject Name: " + SubjectName + "Cost: ";

        }
    }
}
