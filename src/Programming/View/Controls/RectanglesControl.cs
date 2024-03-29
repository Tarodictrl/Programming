﻿using Programming.Model.Geometry;
using System;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int RectanglesCount = 5;

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Создаёт массив прямоугольники.
        /// </summary>
        /// <returns>Возвращает массив прямоугольники.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[RectanglesCount];
            for (int i = 0; i < RectanglesCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        /// <summary>
        /// Находит прямоугольник, чья ширина больше остальных.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс, чья ширина больше остальных.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var index = 0;
            var maxValue = 0;

            for (int i = 0; i < RectanglesCount; i++)
            {
                if (!(rectangles[i].Width > maxValue)) continue;
                maxValue = rectangles[i].Width;
                index = i;
            }

            return index;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.Items.Count == 0) return;
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleIndex = RectanglesListBox.SelectedIndex;

            if (rectangleIndex >= 0)
            {
                _currentRectangle = _rectangles[rectangleIndex];
                HeightTextBox.Text = _currentRectangle.Height.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color.ToString();
                XTextBox.Text = _currentRectangle.Center.X.ToString();
                YTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = Colors.CorrectColor;
            }
            catch
            {
                HeightTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = Colors.CorrectColor;
            }
            catch
            {
                WidthTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = Colors.CorrectColor;
            }
            catch
            {
                ColorTextBox.BackColor = Colors.ErrorColor;
            }
        }
    }
}
