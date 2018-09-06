using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1FamilyDB
{
    public class Member
    {
        #region private fields
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        #endregion

        public string FirstName
        {
            get
            {
                return firstName;
            }// end of get
        }// end of property
        public string LastName
        {
            get
            {
                return lastName;
            }// end of get
        }// end of property
        public string Id
        {
            get
            {
                return id;
            }// end of get
        }// end of property
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }// end of get
        }// end of property

        // constructors
        public Member() { }

        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }// end of constructor

        public Member(string fname, string lname, string pnumber)
        {
            firstName = fname;
            lastName = lname;
            phoneNumber = pnumber;
        }

        public override string ToString()
        {
            return lastName + " " + firstName + " - " + phoneNumber;
        }// end of method
    }// end of class
}
