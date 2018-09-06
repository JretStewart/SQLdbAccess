using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1FamilyDB
{
    public class Family
    {
        private string id;
        private string lastName;
        private string firstName;
        private string age;
        private string relationship;
        private string currentCity;

        
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                value = age;
            }
        }
        public string Relationship
        {
            get
            {
                return relationship;
            }
        }
        public string CurrentCity
        {
            get
            {
                return currentCity;
            }
        }
        public Family(string lname, string fname, string AGE, string rship, string ccity)
        {
            lastName = lname;
            firstName = fname;
            age = AGE;
            relationship = rship;
            currentCity = ccity;
        }
        public Family(string lname, string fname, string rship, string ccity)
        {
            lastName = lname;
            firstName = fname;
            relationship = rship;
            currentCity = ccity;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " - " + age + " - " + relationship + " - " + currentCity;
        }
    }
}
