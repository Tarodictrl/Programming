﻿using Programming.Model;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Наследуется от класса UserControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив с названиями фильмов.
        /// </summary>
        private string[] _titleMovies = { "It", "God", "The Godfather", "The Green Mile", "Intouchables" };

        /// <summary>
        /// Поле, которое представляет генератор случайных чисел.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Коллекция фильмов.
        /// </summary>
        private List<Movie> _movies;

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Красный цвет.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Белый цвет.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _movies = CreateRandomMovies();
            MoviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Создаёт коллекцию фильмов.
        /// </summary>
        /// <returns>Возвращает коллекцию фильмов.</returns>
        private List<Movie> CreateRandomMovies()
        {
            var genres = Enum.GetNames(typeof(Genre));
            var movies = new List<Movie>();

            for (var i = 0; i < movies.Count; i++)
            {
                _currentMovie = new Movie(
                    _titleMovies[i],
                    _random.Next(90, 210),
                    _random.Next(1900, DateTime.Now.Year + 1),
                    genres[_random.Next(0, genres.Length)],
                    Math.Round(_random.NextDouble() * 10, 2));

                movies.Add(_currentMovie);
                MoviesListBox.Items.Add($"Movie {_currentMovie.Id}");
            }

            return movies;
        }

        /// <summary>
        /// Находит фильм, чей рейтинг больше остальных.
        /// </summary>
        /// <param name="movie">Коллекция фильмов.</param>
        /// <returns>Возвращает индекс, чей рейтинг больше остальных.</returns>
        private int FindMovieWithMaxRating(List<Movie> movie)
        {
            int index = 0;
            double maxRating = 0;

            for (int i = 0; i < movie.Count; i++)
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
            DurationTextBox.Text = _currentMovie.DurationTimeInMinutes.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationTimeInMinutes = int.Parse(DurationTextBox.Text);
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
