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
        {
            Address myAddress = new Address(); //create a new address using no-arg
            Console.WriteLine(myAddress);
            // test Propery Accessor Methods 
            myAddress.StreetNum = "11";
            myAddress.StreetName = "This is a Street";
            myAddress.Suburb = "This is a suburb";
            myAddress.Postcode = "5000";
            myAddress.State = "This is a state"; 

            Console.WriteLine("myAddress streetNum:" + myAddress.StreetNum);
            Console.WriteLine("myAddress streetName:" + myAddress.StreetName);
            Console.WriteLine("myAddress suburb:" + myAddress.Suburb);
            Console.WriteLine("myAddress Postcode:" + myAddress.Postcode);
            Console.WriteLine("State:" + myAddress.State);
            
            Address myAddress2 = new Address("123","ABC Street", "Adelaide", "5000", "SA"); //create a new address using all-arg
            Console.Write(myAddress2);
            Console.ReadKey();

        }
    }
}
