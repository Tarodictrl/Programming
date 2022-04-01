using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        public Subject()
        {
        }

        public Subject(string title, int mark, string firstNameTeacher, string lastNameTeacher)
        {
            Title = title;
            Mark = mark;
            FirstNameTeacher = firstNameTeacher;
            LastNameTeacher = lastNameTeacher;
        }

        public string Title { get; set; }

        public int Mark { get; set; }

        public string FirstNameTeacher { get; set; }

        public string LastNameTeacher { get; set; }
    }
}
