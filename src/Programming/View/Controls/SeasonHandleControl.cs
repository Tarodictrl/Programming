using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
        public event EventHandler<ColorSelectedEventArgs> ColorSelected;

        public SeasonHandleControl()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(Seasons));

            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }

            ChooseSeasonComboBox.SelectedIndex = 0;
        }   

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    ColorSelected?.Invoke(this, new ColorSelectedEventArgs(Color.FromArgb(69, 83, 226)));
                    break;
                case Seasons.Summer:
                    ColorSelected?.Invoke(this, new ColorSelectedEventArgs(Color.FromArgb(85, 156, 69)));
                    break;
                case Seasons.Spring:
                    ColorSelected?.Invoke(this, new ColorSelectedEventArgs(Color.FromArgb(226, 215, 69)));
                    break;
                case Seasons.Autumn:
                    ColorSelected?.Invoke(this, new ColorSelectedEventArgs(Color.FromArgb(226, 156, 69)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
    public class ColorSelectedEventArgs : EventArgs
    {
        public ColorSelectedEventArgs(Color color)
        {
            Color = color;
        }

        public Color Color { get; set; }
    }
}
