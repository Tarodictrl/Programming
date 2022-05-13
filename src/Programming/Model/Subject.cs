namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="title">Название дисциплины.</param>
        /// <param name="mark">Оценка по дисциплине. Число в диапозоне от 0 до 5.</param>
        /// <param name="firstNameTeacher">Имя преподавателя.</param>
        /// <param name="lastNameTeacher">Фамилия преподавателя</param>
        public Subject(string title, int mark, string firstNameTeacher, string lastNameTeacher)
        {
            Title = title;
            Mark = mark;
            FirstNameTeacher = firstNameTeacher;
            LastNameTeacher = lastNameTeacher;
        }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Число в диапазоне от 0 до 5.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт фамилию преподавателя.
        /// </summary>
        public string FirstNameTeacher { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string LastNameTeacher { get; set; }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Title { get; set; }
    }
}
