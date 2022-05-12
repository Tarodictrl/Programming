using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = ParseInput.Text;

            if (Enum.TryParse(text, out Weekday day))
            {
                OutLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }
    }
}
