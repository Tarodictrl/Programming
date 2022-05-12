using Programming.Model;
using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        private string[] _titleMovies = { "It", "God", "The Godfather", "The Green Mile", "Intouchables" };

        private Random _random = new Random();

        private Movie[] _movies;

        private Movie _currentMovie;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        public MoviesControl()
        {
            InitializeComponent();

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

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
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

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TitleTextBox.Text;
        }
    }
}
