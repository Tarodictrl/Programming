using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using System.Collections.Generic;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private Random _random = new Random();

        private string[] _titleMovies = { "It", "God", "The Godfather", "The Green Mile", "Intouchables" };

        private List <Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();

            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }

            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;

            var values = Enum.GetValues(typeof(Seasons));

            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }

            _movies = CreateRandomMovies(5);
            MoviesListBox.SelectedIndex = 0;
        }
        
        private Movie[] CreateRandomMovies(int count)
        {
            var genres = Enum.GetNames(typeof(Genre));
            var movies = new Movie[count];

            for (var i = 0; i < movies.Length; i++)
            {
                movies[i] = new Movie(
                    _titleMovies[i], 
                    _random.Next(90, 210),
                    _random.Next(1900, DateTime.Now.Year + 1),
                    genres[_random.Next(0, genres.Length)],
                    Math.Round(_random.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(movies[i].ToString());
            }

            return movies;
        }

        private int FindRectangleWithMaxWidth(List <Rectangle> rectangles)
        {
            var index = 0;
            var maxWidth = 0;

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void RemoveTextFromTextBox()
        {
            IdRectangleTextBox.Clear();
            XRectangleTextBox.Clear();
            YRectangleTextBox.Clear();
            WidthRectangleTextBox.Clear();
            HeightRectangleTextBox.Clear();

            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }

        private int FindMovieWithMaxRating(Movie[] movie)
        {
            int index = 0;
            double maxRating = 0;

            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Rating > maxRating)
                {
                    maxRating = movie[i].Rating;
                    index = i;
                }
            }

            return index;
        }

        private void UpdateListBoxes()
        {
            AddingRectanglesListBox.Items.Clear();
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                AddingRectanglesListBox.Items.Add(_rectangles[i]);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }

            AddingRectanglesListBox.SelectedIndex = _rectangles.Count - 1;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values;

            switch (itemType)
            {
                case Enums.Colors:
                    values = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = ParseInput.Text;

            if (Enum.TryParse(text, out Weekday day))
            {
                OutLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = _correctColor;
            }
            catch
            {
                HeightTextBox.BackColor = _errorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = _correctColor;
            }
            catch
            {
                WidthTextBox.BackColor = _errorColor;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexMovie];
            TitleTextBox.Text = _currentMovie.Title;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = _correctColor;
            }
            catch
            {
                DurationTextBox.BackColor = _errorColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = _correctColor;
            }
            catch
            {
                RatingTextBox.BackColor = _errorColor;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                ReleaseYearTextBox.BackColor = _correctColor;
            }
            catch
            {
                ReleaseYearTextBox.BackColor = _errorColor;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _rectangles.Add(new Rectangle(
                _random.Next(0, 100),
                _random.Next(0, 100),
                "Green",
                new Point2D(_random.Next(0, 425), _random.Next(0, 587))
                ));
            UpdateListBoxes();
        }

        private void AddingRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            HeightRectangleTextBox.Text = _currentRectangle.Height.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(rectangleIndex);
                UpdateListBoxes();
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            UpdateListBoxes();
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthRectangleTextBox.Text);
                WidthRectangleTextBox.BackColor = _correctColor;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(HeightRectangleTextBox.Text);
                HeightRectangleTextBox.BackColor = _correctColor;
            }
            catch
            {
                HeightRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}