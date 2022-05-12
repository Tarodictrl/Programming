using Programming.Model.Geometry;
using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private const int RectanglesCount = 5;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;

        }

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
                HeightTextBox.BackColor = _correctColor;
            }
            catch
            {
                HeightTextBox.BackColor = _errorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

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
    }
}
