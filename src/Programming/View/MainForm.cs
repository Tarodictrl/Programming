using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model;
using System.Collections.Generic;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private readonly Color _intersect = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _unIntersect = Color.FromArgb(127, 127, 255, 127);

        private Random _random = new Random();

        private string[] _titleMovies = { "It", "God", "The Godfather", "The Green Mile", "Intouchables" };

        private List <Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        private List <Panel> _rectanglePanels = new List<Panel>();

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

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = AddingRectanglesListBox.FindString(rectangle.Id.ToString());
            AddingRectanglesListBox.Items[index] = rectangle.GetRectangleInfo();
        }

        private void ClearRectangleInfo()
        {
            IdRectangleTextBox.Clear();
            XRectangleTextBox.Clear();
            YRectangleTextBox.Clear();
            WidthRectangleTextBox.Clear();
            HeightRectangleTextBox.Clear();

            IdRectangleTextBox.BackColor = _correctColor;
            XRectangleTextBox.BackColor = _correctColor;
            YRectangleTextBox.BackColor = _correctColor;
            WidthRectangleTextBox.BackColor = _correctColor;
            HeightRectangleTextBox.BackColor = _correctColor;

            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();

            IdTextBox.BackColor = _correctColor;
            XTextBox.BackColor = _correctColor;
            YTextBox.BackColor = _correctColor;
            WidthTextBox.BackColor = _correctColor;
            HeightTextBox.BackColor = _correctColor;
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
                AddingRectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
             AddingRectanglesListBox.SelectedIndex = _rectangles.Count - 1;
        }

        private void FindCollisions()
        {
            for (int n = 0; n < _rectangles.Count; n++)
            {
                CanvasPanel.Controls[n].BackColor = _unIntersect;
                _rectangles[n].Colour = "Green";
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectangles[i].Colour = "Red";
                        _rectangles[j].Colour = "Red";

                        CanvasPanel.Controls[i].BackColor = _intersect;
                        CanvasPanel.Controls[j].BackColor = _intersect;
                    }
                }
            }
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
            if (rectangleIndex >= 0)
            {
                _currentRectangle = _rectangles[rectangleIndex];
                HeightTextBox.Text = _currentRectangle.Height.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Colour.ToString();
                XTextBox.Text = _currentRectangle.Center.X.ToString();
                YTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
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
            if (_rectangles.Count > 0)
            {
                RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
            }
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(newRectangle);

            Panel rectanglePanel = new Panel
            {
                Width = newRectangle.Width,
                Height = newRectangle.Height,
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y),
                BackColor = _unIntersect,
                BorderStyle = BorderStyle.FixedSingle
            };

            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            UpdateListBoxes();
        }

        private void AddingRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex != -1)
            {
                int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[rectangleIndex];
                HeightRectangleTextBox.Text = _currentRectangle.Height.ToString();
                WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
                XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(rectangleIndex);
                _rectanglePanels.RemoveAt(rectangleIndex);
                CanvasPanel.Controls.RemoveAt(rectangleIndex);
                UpdateListBoxes();
                FindCollisions();
            }
            if (_rectangles.Count == 0) {
               ClearRectangleInfo();
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            UpdateListBoxes();
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthRectangleTextBox.Text);
                WidthRectangleTextBox.BackColor = _correctColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightRectangleTextBox.Text);
                HeightRectangleTextBox.BackColor = _correctColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = _correctColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                if (AddingRectanglesListBox.SelectedIndex >= 0) {
                    _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                    YRectangleTextBox.BackColor = _correctColor;
                    CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentRectangle);
                }
            }
            catch
            {
                YRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxes();
            FindCollisions();
        }
    }
}