using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private string _title;

        private int _mark;
        
        private string _firstNameTeacher;

        private string _lastNameTeacher;

        public Subject()
        {
        }

        public Subject(string title, int mark, string firstNameTeacher, string lastNameTeacher)
        {
            Title = title;
            Grade = mark;
            FirstNameTeacher = firstNameTeacher;
            LastNameTeacher = lastNameTeacher;
        }

        public string Title { get; set; }

        public int Grade { get; set; }

        public string FirstNameTeacher { get; set; }

        public string LastNameTeacher { get; set; }
    }
}
