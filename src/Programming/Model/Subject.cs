namespace Programming.Model
{
    public class Subject
    {
        private int _mark;

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

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }

        public string FirstNameTeacher { get; set; }

        public string LastNameTeacher { get; set; }

        public string Title { get; set; }
    }
}
