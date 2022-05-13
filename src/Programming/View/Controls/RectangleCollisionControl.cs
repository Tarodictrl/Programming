using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectangleCollisionControl : UserControl
    {
        private readonly Color _intersect = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _unIntersect = Color.FromArgb(127, 127, 255, 127);

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectangleCollisionControl()
        {
            InitializeComponent();
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
        }

        private void FindCollisions()
        {
            for (int n = 0; n < _rectangles.Count; n++)
            {
                CanvasPanel.Controls[n].BackColor = _unIntersect;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = _intersect;
                        CanvasPanel.Controls[j].BackColor = _intersect;
                    }
                }
            }
        }

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
                BackColor = _unIntersect,
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
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

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

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

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
    }
}
