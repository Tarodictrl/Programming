using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (Enums EnumValue in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(EnumValue);
            }
            EnumsListBox.SelectedIndex = 0;
            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                ChooseSeasonCombo.Items.Add(value);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var c = EnumsListBox.SelectedIndex;
            var itemType = (Enums)c;
            Array values;
            switch (itemType)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Season:
                    values = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }
            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ListBox)sender).SelectedItem;
            IntBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = ParseInput.Text;
            if (Enum.IsDefined(typeof(Weekday), text))
            {
                var day = Enum.Parse(typeof(Weekday), text, true);
                OutLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonCombo.SelectedItem;
            switch (item)
            {
                case Season.Winter:
                    tabPage1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Season.Summer:
                    tabPage1.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Season.Autumn:
                    tabPage1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Spring:
                    tabPage1.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
