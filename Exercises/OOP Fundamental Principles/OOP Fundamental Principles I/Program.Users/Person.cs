using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Users
{
    public class Person
    {
        private string firstName;
        private string lastName;  
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public Person(string firstname, string lastname, string email)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.email = email; 
        }

        public string Walk()
        {
            int distanceWalked = this.firstName.Length;
            int realDistance = distanceWalked * 1000;
            return "This person walked " + realDistance + " meters!";

        }

    }
}
