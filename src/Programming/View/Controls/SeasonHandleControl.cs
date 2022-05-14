using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по выбору времени года.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Предоставляет реализацию по изменение фона с выбором времени года.
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
        public static event EventHandler<ColorSelectedEventArgs> SeasonChanged;

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (ChooseSeasonComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    SeasonChanged?.Invoke(this, new ColorSelectedEventArgs(Colors.Winter));
                    break;
                case Seasons.Summer:
                    SeasonChanged?.Invoke(this, new ColorSelectedEventArgs(Colors.Summer));
                    break;
                case Seasons.Spring:
                    SeasonChanged?.Invoke(this, new ColorSelectedEventArgs(Colors.Spring));
                    break;
                case Seasons.Autumn:
                    SeasonChanged?.Invoke(this, new ColorSelectedEventArgs(Colors.Autumn));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
