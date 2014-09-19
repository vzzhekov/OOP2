using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Users
{
    public class University_Teacher : Teacher, TalkTalk 
    {
        private string university;

        public string University
        {
            get { return university; }
            set { university = value; }
        } 

        public University_Teacher(string firstname, string lastname, string email, string courses, string university)
            : base(firstname, lastname, email, courses)
        {
            this.university = university; 
        }


        public string Talks()
        {
            return "fdasfsdaf";
        }
    }
}
