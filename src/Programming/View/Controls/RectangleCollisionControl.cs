using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Коллекция отображаемых панелей.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleCollisionControl"/>.
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямугольник, данные которого нужно обновить.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = AddingRectanglesListBox.FindString(rectangle.Id.ToString());
            AddingRectanglesListBox.Items[index] = rectangle.GetRectangleInfo();
        }

        /// <summary>
        /// Очищает данные с текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdRectangleTextBox.Clear();
            XRectangleTextBox.Clear();
            YRectangleTextBox.Clear();
            WidthRectangleTextBox.Clear();
            HeightRectangleTextBox.Clear();
        }

        /// <summary>
        /// Находит пересечение прямоугольников и красит их в красный.
        /// </summary>
        private void FindCollisions()
        {
            for (int n = 0; n < _rectangles.Count; n++)
            {
                CanvasPanel.Controls[n].BackColor = Colors.IsNotCollision;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Colors.IsCollision;
                        CanvasPanel.Controls[j].BackColor = Colors.IsCollision;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        private void UpdateListBoxes()
        {
            AddingRectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                AddingRectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
            }

            AddingRectanglesListBox.SelectedIndex = _rectangles.Count - 1;
        }

        private void AddingRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            HeightRectangleTextBox.Text = _currentRectangle.Height.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
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
                BackColor = Colors.IsNotCollision,
                BorderStyle = BorderStyle.FixedSingle
            };

            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            UpdateListBoxes();
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
            else
            {
                ClearRectangleInfo();
            }
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthRectangleTextBox.Text);
                WidthRectangleTextBox.BackColor = Colors.CorrectColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthRectangleTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightRectangleTextBox.Text);
                HeightRectangleTextBox.BackColor = Colors.CorrectColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightRectangleTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = Colors.CorrectColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XRectangleTextBox.BackColor = Colors.ErrorColor;
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

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                if (AddingRectanglesListBox.SelectedIndex >= 0)
                {
                    _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                    YRectangleTextBox.BackColor = Colors.CorrectColor;
                    CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentRectangle);
                }
            }
            catch
            {
                YRectangleTextBox.BackColor = Colors.ErrorColor;
            }
        }
    }
}
