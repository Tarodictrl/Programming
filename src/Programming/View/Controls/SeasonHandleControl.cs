using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Наследуется от класса UserControl.
        /// </summary>
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

        /// <summary>
        /// Событие при изменении цвета.
        /// </summary>
        public static event EventHandler<ColorSelectedEventArgs> ColorSelected;

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (ChooseSeasonComboBox.SelectedItem)
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

    /// <summary>
    /// Наследуется от базового класса EventArgs.
    /// </summary>
    public class ColorSelectedEventArgs : EventArgs
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="ColorSelectedEventArgs"/>.
        /// </summary>
        /// <param name="color">Цвет.</param>
        public ColorSelectedEventArgs(Color color)
        {
            Color = color;
        }

        /// <summary>
        /// Возвращает и задаёт цвет.
        /// </summary>
        public Color Color { get; set; }
    }
}
