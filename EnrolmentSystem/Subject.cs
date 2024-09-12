namespace EnrolmentSystem
{
    public class Subject
    {
        //private string subjectCode;
        //private string subjectName;
        //private double cost;


        // Constants for default values
        const string DEF_SUBJECT_CODE = "None Provided";
        const string DEF_SUBJECT_NAME = "No Name Provided";
        const double DEF_COST = 0;

        //Property Assessor Methods:
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }


        // No-argument constructor 
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
        }

        // All-argument constructor
        public Subject(string subjectName, string subjectCode, double cost)
        {
            SubjectName = subjectName;
            SubjectCode = subjectCode;
            Cost = cost;

        }


        //ToSTring 

        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + "Subject Name: " + SubjectName + "Cost: " + Cost;

        }
    }
}
