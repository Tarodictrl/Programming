using MoviesApp.Model;
using MoviesApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoviesApp.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция фильмов.
        /// </summary>
        private List<Movie> _movies;

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Текст поиска.
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Genre));

            foreach (var item in items)
            {
                MovieGenreComboBox.Items.Add(item);
            }

            _movies = Serializer.Deserialize();
            if (_movies.Count == 0) MovieGroupBox.Enabled = false;

            UpdateListBox(-1);
        }

        /// <summary>
        /// Организует поиск полей у объектов,
        /// удовлетворяющих введенному в строку значению.
        /// </summary>
        /// <param name="searchText">Строка по которой нужно искать.</param>
        /// <returns>Список объектов подходящих под введенную строку.</returns>
        private List<Movie> SearchMovies()
        {
            var result = from movie in _movies
                         where movie.Name.Contains(_searchText) ||
                         movie.ReleaseYear.ToString().Contains(_searchText) ||
                         movie.Rating.ToString().Contains(_searchText) ||
                         movie.DurationTimeInMinutes.ToString().Contains(_searchText) ||
                         movie.Genre.Contains(_searchText)
                         select movie;

            return result.ToList();
        }

        /// <summary>
        /// Сортировка _movies.
        /// </summary>
        private void SortingMovies()
        {
            _movies = (from Movie in _movies
                       orderby Movie.Name
                       select Movie).ToList();
        }

        /// <summary>
        /// Очищает поля для вывода информации.
        /// </summary>
        private void ClearInfo()
        {
            MoviesListBox.SelectedIndex = -1;
            MovieGenreComboBox.SelectedIndex = -1;
            MovieReleaseYearTextBox.Clear();
            MovieNameTextBox.Clear();
            MovieRatingTextBox.Clear();
            MovieDurationTextBox.Clear();
        }

        /// <summary>
        /// Обновляет данные в списке MoviesListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Movie> movies;

            MoviesListBox.Items.Clear();

            if (_searchText != "" && _searchText != null) movies = SearchMovies();
            else movies = _movies;

            foreach (var movie in movies)
            {
                if (movie.Name != null)
                {
                    MoviesListBox.Items.Add(
                        $"{movie.Name} - {movie.ReleaseYear} - {movie.Genre}");
                }
                else
                {
                    MoviesListBox.Items.Add($"Movie {movie.Id}");
                }
            }

            if (-1 <= index && index < MoviesListBox.Items.Count) 
                MoviesListBox.SelectedIndex = index;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var movie = new Movie();
            _movies.Add(movie);
            SortingMovies();
            UpdateListBox(_movies.IndexOf(movie));
            MovieGroupBox.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            _movies.RemoveAt(MoviesListBox.SelectedIndex);

            if (_movies.Count == 0)
            {
                MovieGroupBox.Enabled = false;
                ClearInfo();
            }
            else
            {
                MovieGroupBox.Enabled = true;
            }

            UpdateListBox(-1);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            if (_searchText == "" || _searchText == null) 
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
            else 
                _currentMovie = SearchMovies()[MoviesListBox.SelectedIndex];

            MovieNameTextBox.Text = _currentMovie.Name;
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieGenreComboBox.Text = _currentMovie.Genre;
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieDurationTextBox.Text = _currentMovie.DurationTimeInMinutes.ToString();
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.Name = MovieNameTextBox.Text;
                MovieNameTextBox.BackColor = AppColors.CorrectColor;
                SortingMovies();
                UpdateListBox(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.ReleaseYear = int.Parse(MovieReleaseYearTextBox.Text);
                MovieReleaseYearTextBox.BackColor = AppColors.CorrectColor;
                SortingMovies();
                UpdateListBox(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.Rating = int.Parse(MovieRatingTextBox.Text);
                MovieRatingTextBox.BackColor = AppColors.CorrectColor;
                SortingMovies();
                UpdateListBox(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.Genre = MovieGenreComboBox.SelectedItem.ToString();
                MovieReleaseYearTextBox.BackColor = AppColors.CorrectColor;
                SortingMovies();
                UpdateListBox(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie.DurationTimeInMinutes = int.Parse(MovieDurationTextBox.Text);
                MovieDurationTextBox.BackColor = AppColors.CorrectColor;
                SortingMovies();
                UpdateListBox(_movies.IndexOf(_currentMovie));
            }
            catch
            {
                MovieDurationTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _searchText = SearchTextBox.Text;
            ClearInfo();
            UpdateListBox(-1);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = MoviesApp.Properties.Resources.add_24x24_black;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = MoviesApp.Properties.Resources.add_24x24;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = MoviesApp.Properties.Resources.cross_circle_24x24_black;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = MoviesApp.Properties.Resources.cross_circle_24x24;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_movies);
        }
    }
}