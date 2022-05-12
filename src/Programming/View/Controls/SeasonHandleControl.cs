using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
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
            switch (ChooseSeasonComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    break;
                case Seasons.Summer:
                    break;
                case Seasons.Spring:
                    break;
                case Seasons.Autumn:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
