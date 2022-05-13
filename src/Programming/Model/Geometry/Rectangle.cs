namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Общее количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника. Положительное число.</param>
        /// <param name="width">Ширина прямоугольника. Положительное число.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты прямоугольника.</param>
        public Rectangle(int height, int width, string color, Point2D center)
        {
            Height = height;
            Color = color;
            Width = width;
            Center = center;
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задаёт высоту прямоугольника. Положительное число.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Положительное число.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Информация о прямоугольнике.
        /// </summary>
        /// <returns>Строка вида id: (X; Y; W; H)</returns>
        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; H={_height})";
        }

        /// <summary>
        /// Возвращает общее количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт координаты прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }
    }
}
