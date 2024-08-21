﻿using System;
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
            Console.Write(myAddress2 + "\n\n");

            //Student Class Test 

            Student myStudent = new Student(); //create a new student using no-arg 
           

            //test property accessor methods 
            myStudent.StudentID = "001123";
            myStudent.Program = "This is a program";
            myStudent.DateRegistered = new DateTime();
            myStudent.StudentEnrollment = new Enrollment ();

            Console.WriteLine("Student ID:" + myStudent.StudentID);
            Console.WriteLine("Program:" + myStudent.Program);
            Console.WriteLine("Date Registered:" + myStudent.DateRegistered);
            Console.WriteLine("Enrollment:" + myStudent.StudentEnrollment + "\n");



            Student myStudent2 = new Student("0011456", "Diploma in IT Studies",new DateTime(2024,01,10) , new Enrollment()); //create a new student using all-arg
            Console.Write(myStudent2);

            // Create two Student objects with the same StudentID
            Student student1 = new Student("S123", "Computer Science", new DateTime(2022,7,11), new Enrollment());
            Student student2 = new Student("S123", "Information Technology",new DateTime(), new Enrollment());

            // Create a third Student object with a different StudentID
            Student student3 = new Student("S456", "Business", new DateTime(), new Enrollment());

            // Test Equals method
            Console.WriteLine("Testing Equals method:");
            Console.WriteLine($"student1 equals student2: {student1.Equals(student2)}");  // Should return a True
            Console.WriteLine($"student1 equals student3: {student1.Equals(student3)}");  // Should return a  False

            // Test == operator
            Console.WriteLine("\nTesting == operator:");
            Console.WriteLine($"student1 == student2: {student1 == student2}");  // Should return a True
            Console.WriteLine($"student1 == student3: {student1 == student3}");  // Should return a False

            // Test != operator
            Console.WriteLine("\nTesting != operator:");
            Console.WriteLine($"student1 != student2: {student1 != student2}");  // Should return return a  False
            Console.WriteLine($"student1 != student3: {student1 != student3}");  // Should return return a  True

            // Test GetHashCode method
            Console.WriteLine("\nTesting GetHashCode method:");
            Console.WriteLine($"student1 hash code: {student1.GetHashCode()}");
            Console.WriteLine($"student2 hash code: {student2.GetHashCode()}");
            Console.WriteLine($"student3 hash code: {student3.GetHashCode()}");

            // Check if the hash codes for student1 and student2 are the same
            Console.WriteLine($"\nstudent1 and student2 have the same hash code: {student1.GetHashCode() == student2.GetHashCode()}");  // Should return a False
            Console.WriteLine($"student1 and student3 have the same hash code: {student1.GetHashCode() == student3.GetHashCode()}\n\n");  // Should return a False


            //Subject Class Test 

            Subject mySubject = new Subject(); //create a new subject using no-arg 
        

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
        

            //test property accessor methods 
            myEnrollment.DateEnrolled = new DateTime(2023,2,23);
            myEnrollment.Grade = "Pass";
            myEnrollment.Semester = "Semester1";
            myEnrollment.SubjectEnrollment = new Subject();

            Console.WriteLine("Subject Name:" + myEnrollment.DateEnrolled);
            Console.WriteLine("Grade:" + myEnrollment.Grade);
            Console.WriteLine("Semester:" + myEnrollment.Semester);
            Console.WriteLine("Subject:" + myEnrollment.SubjectEnrollment + "\n");

            Enrollment myEnrollment2 = new Enrollment(new DateTime(2023,2,15), "fail", "semester2", new Subject("SQL Database", "ICT223",6000)); //create a new enrollment using all-arg
            Console.WriteLine(myEnrollment2);
            
            

            //Person CLass Test 


            Person myPerson = new Person(); //create a new Person using no-arg 
      

            //test property accessor methods 
            myPerson.PersonName = "Neil";
            myPerson.PersonEmail = "neil@email.com";
            myPerson.PhoneNum = "0457954545";
            myPerson.PersonAddress = new Address("22", "This is another road", "This is another city","8000", "This is another state");

            Console.WriteLine("Person Name:" + myPerson.PersonName); 
            Console.WriteLine("Person Email:" + myPerson.PersonEmail);
            Console.WriteLine("Person Number:" + myPerson.PhoneNum);
             Console.WriteLine("Address:" + myPerson.PersonAddress + "\n");

            Person myPerson2 = new Person("Lilly Page", "lillyP@gmail.com", "0456988864", new Address("55", "First Avenue","Ealing", "W12L99","London")); //create a new enrollment using all-arg
            Console.Write(myPerson2);

            Console.ReadKey();





        }
    }
}
