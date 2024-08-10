namespace EnrolmentSystem
{
    internal class Person
    {
        private string name;
        private string email;
        private int phoneNumber;

        //Property Assessor Methods:
        public string PersonName { get; set; }
        public string PersonEmail { set; get; }
        public string PhoneNum { get; set; }



        //constants for defaults

        const string DEF_NAME = "None provided";
        const string DEF_EMAIL = "None provided";
        const int DEF_PHONE_NUM = 0;

        // Static variables
        public static int totalPersons = 0; //  Static variable - count persons objects

        // No-argument constructor

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUM)

        {

        }
        // All-argument constructor
        public Person(string PersonName, string PersonEmail, int PhoneNum)
        {
            PersonName = name;
            PersonEmail = email;
            PhoneNum = phoneNumber;
            totalPersons++; // Increment static variable

        }


        //ToSTring 

        public override string ToString()
        {
            return "Person Name: " + PersonName + "Email: " + PersonEmail + "Phone Number: " + PhoneNum + "Address:" + PersonAddress;

        }

        // Static method
        public static int GetTotalPersons()
        {
            //get
            { return totalPersons; }

        }


    }
}
