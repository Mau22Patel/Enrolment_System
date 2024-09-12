using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace EnrolmentSystem
{
    public class Person
    {
        // Constants for defaults
        const string DEF_NAME = "None provided";
        const string DEF_EMAIL = "None provided";
        const string DEF_PHONE_NUM = "None provided";

        // Property Accessor Methods:
        public string PersonName { get; set; }
        public string PersonEmail { get; set; }
        public string PhoneNum { get; set; }
        public Address PersonAddress { get; set; }

        // No-argument constructor
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUM, new Address())
        {
        }

        // All-argument constructor
        public Person(string personName, string personEmail, string phoneNum, Address address)
        {
            PersonName = personName;
            PersonEmail = personEmail;
            PhoneNum = phoneNum;
            PersonAddress = address;
        }

        //ToSTring 

        public override string ToString()
        {
            return "Person Name: " + PersonName + "\nPerson Email: " + PersonEmail + "\nPerson Number : " + PhoneNum + "\nPerson Address:" + PersonAddress;

        }

   

       
    }
}