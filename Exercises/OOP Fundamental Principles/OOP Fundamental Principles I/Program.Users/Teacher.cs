using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Users
{
    public class Teacher : Person
    {
        private string coursesTaught;

        public string CoursesTaught
        {
            get { return coursesTaught; }
            set { coursesTaught = value; }
        }

        public Teacher(string firstname, string lastname, string email, string courses)
            : base(firstname, lastname, email)
        {
            this.coursesTaught = courses;
        }

      public override string ToString()
        {
            return this.FirstName + "," + this.LastName + "," + this.Email + "," + this.coursesTaught; 
        }


    }
}
