using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    internal class Program
    {
        static void Main(string[] args)

            //Address Class Test 
        {
            Address myAddress = new Address(); //create a new address using no-arg
            Console.WriteLine(myAddress + "\n");

            // test property Accessor Methods 
            myAddress.StreetNum = "11";
            myAddress.StreetName = "This is a Street";
            myAddress.Suburb = "This is a suburb";
            myAddress.Postcode = "5000";
            myAddress.State = "This is a state" + "\n"; 

            Console.WriteLine("Street Number:" + myAddress.StreetNum);
            Console.WriteLine("Street Name:" + myAddress.StreetName);
            Console.WriteLine("Suburb:" + myAddress.Suburb);
            Console.WriteLine("Postcode:" + myAddress.Postcode);
            Console.WriteLine("State:" + myAddress.State + "\n");
            
            Address myAddress2 = new Address("123","ABC Street", "Adelaide", "5000", "SA"); //create a new address using all-arg
            Console.Write(myAddress2 + "\n");

            //Student Class Test 

            Student myStudent = new Student(); //create a new student using no-arg 
            Console.WriteLine(myStudent);

            //test property accessor methods 
            myStudent.StudentID = "001123";
            myStudent.Program = "This is a program";
            myStudent.DateRegistered = new DateTime();
            myStudent.StudentEnrollment = new Enrollment ();

            Console.WriteLine("Student ID:" + myStudent.StudentID);
            Console.WriteLine("Program:" + myStudent.Program);
            Console.WriteLine("Date Registered:" + myStudent.DateRegistered);
            Console.WriteLine("Enrollment:" + myStudent.StudentEnrollment + "\n");



            Student myStudent2 = new Student("0011456", "Diploma in IT Studies",new DateTime() , new Enrollment()); //create a new student using all-arg
            Console.Write(myStudent2);

            //Subject Class Test 

            Subject mySubject = new Subject(); //create a new subject using no-arg 
            Console.WriteLine(mySubject);

            //test property accessor methods 
            mySubject.SubjectName = "C# Advanced";
            mySubject.SubjectCode = "ICT667";
            mySubject.Cost = 2000;
            

            Console.WriteLine("Subject Name:" + mySubject.SubjectName);
            Console.WriteLine("Subject Code:" + mySubject.SubjectCode);
            Console.WriteLine("Cost:" + mySubject.Cost);

            Subject mySubject2 = new Subject("Leadership and Faciliate", "BSB202", 3000); //create a new subject using all-arg
            Console.Write(mySubject2);


            //Enrollment Class Test 

            Enrollment myEnrollment = new Enrollment(); //create a new enrollment using no-arg 
            Console.WriteLine(myEnrollment);

            //test property accessor methods 
            myEnrollment.DateEnrolled = new DateTime();
            myEnrollment.Grade = "Pass";
            myEnrollment.Semester = "Semester1";
            myEnrollment.SubjectEnrollment = new Subject();

            Console.WriteLine("Subject Name:" + myEnrollment.DateEnrolled);
            Console.WriteLine("Grade:" + myEnrollment.Grade);
            Console.WriteLine("Semester:" + myEnrollment.Semester);
            Console.WriteLine("Subject:" + myEnrollment.SubjectEnrollment + "\n");

            Enrollment myEnrollment2 = new Enrollment(new DateTime(), "fail", "semester2", new Subject()); //create a new enrollment using all-arg
            Console.Write(myEnrollment2);

            

            //Person CLass Test 


            Person myPerson = new Person(); //create a new Person using no-arg 
            Console.WriteLine(myPerson);

            //test property accessor methods 
            myPerson.PersonName = "Neil";
            myPerson.PersonEmail = "neil@email.com";
            myPerson.PhoneNum = "0457954545";
            Address PnoneAddress = new Address();

            Console.WriteLine("Person Name:" + myPerson.PersonName); 
            Console.WriteLine("Person Email:" + myPerson.PersonEmail);
            Console.WriteLine("Person Number:" + myPerson.PhoneNum);
             Console.WriteLine("Address:" + myPerson.PersonAddress + "\n");

            Person myPerson2 = new Person("Lilly Page", "lillyP@gmail.com", "0456988864", new Address()); //create a new enrollment using all-arg
            Console.Write(myPerson2);

            Console.ReadKey();





        }
    }
}
