using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Address
    {
        //private string streetName;
        //private string streetNum;
        //private string suburb;
        //private string postcode;
        //private string state;
        //constants for defaults

        const string DEF_STREET_NUM = "None provided";
        const string DEF_STREET_NAME = "None provided";
        const string DEF_SUBURB = "None provided";
        const string DEF_POSTCODE = "None provided";
        const string DEF_STATE = "None provided";

        //Property Assessor Methods:
        public string StreetNum { get; set; }
        public string StreetName {  set; get; }
        public string Suburb {  get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // No-argument constructor

        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)

        {

        }
        // All-argument constructor
        public Address (string streetNum, string streetName, string suburb,string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state; 
        }


        //ToSTring 

        public override string ToString()
        {
            return "street num: " + StreetNum + "\nstreet name: " + StreetName + "\nsuburb: " + Suburb + "\npostcode:" + Postcode + "\nstate: " + State;
                
                }


    }
}
