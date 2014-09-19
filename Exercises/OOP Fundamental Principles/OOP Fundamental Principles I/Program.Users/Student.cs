using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Users
{
    public class Student : Person
    {
        private int studentId;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        
        public Student(string firstname, string lastname, string email, int studentId)
            : base(firstname, lastname, email)
        {
            this.studentId = studentId; 
        }

        public override string ToString()
        {
            return this.FirstName + " ; " + this.LastName + " ; " + this.Email + " ; " + this.studentId;
        }
    } 
}
