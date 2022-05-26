using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BuildingsApp.Model.Enums;
using BuildingsApp.Model;

namespace BuildingsApp.View.Controls
{
    public partial class BuildingsControl : UserControl
    {
        private List<Building> _buildings = new List<Building>();

        private Building _currentBuilding;

        public BuildingsControl()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(Category));

            foreach(var value in values)
            {
                CategoryComboBox.Items.Add(value);
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        private void UpdateListBox()
        {
            BuildingsListBox.Items.Clear();

            foreach (var building in _buildings)
            {
                BuildingsListBox.Items.Add(building.GetBuildingInfo());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newBuilding = new Building
                {
                    Name = BuildingNameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Category = CategoryComboBox.SelectedItem.ToString(),
                    Rating = int.Parse(RatingTextBox.Text)
                };

                _buildings.Add(newBuilding);
                UpdateListBox();
            }
            catch
            {
                MessageBox.Show("Заполните все поля!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validator.AssertValueInRange(int.Parse(RatingTextBox.Text), 0, 5, "Rating");
                RatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
