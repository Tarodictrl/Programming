﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Enums d in Enum.GetValues(typeof(Enums)))
            {
                EnumListBox.Items.Add(d);
            }
            EnumListBox.SetSelected(0, true);

            var values = Enum.GetValues(typeof(Season));

            foreach (var value in values)
            {
                ChooseSeasonCombo.Items.Add(value);
            }
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var c = EnumListBox.SelectedIndex;
            var itemType = (Enums)c;
            switch (itemType)
            {
                case Enums.Color:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Color)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                case Enums.Season:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }


        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = ValuesListBox.SelectedIndex;
            IntBox.Text = i.ToString();
        }

        private void ParseBtn_Click_1(object sender, EventArgs e)
        {
            var text = ParseInput.Text;
            if (Enum.IsDefined(typeof(Weekday), text))
            {
                var day = Enum.Parse(typeof(Weekday), text, true);
                OutText.Text = $"Это день недели ({day} = {day.GetHashCode()})";
            }
            else
            {
                OutText.Text = "Нет такого дня недели!";
            }
        }

        private void GoBtn_Click(object sender, EventArgs e)
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
