using BuildingsApp.Model;
using BuildingsApp.Model.Enums;
using System;
using System.Windows.Forms;

namespace BuildingsApp.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению дочернего окна добавления строения.
    /// </summary>
    public partial class AddBuildingForm : Form
    {
        /// <summary>
        /// Событие при добавлении строения.
        /// </summary>
        public event EventHandler<BuildingAddedEventArgs> BuildingAdded;

        /// <summary>
        /// Строение.
        /// </summary>
        public Building _build = new Building();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddBuildingForm"/>.
        /// </summary>
        public AddBuildingForm()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                BuildingCategoryComboBox.Items.Add(item);
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuildingNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _build.Name = BuildingNameTextBox.Text;
                BuildingNameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void BuildingAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _build.Address = BuildingAddressTextBox.Text;
                BuildingAddressTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingAddressTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void BuildingRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _build.Rating = int.Parse(BuildingRatingTextBox.Text);
                BuildingRatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingRatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!Validator.AssertCorrectText(BuildingAddressTextBox, BuildingNameTextBox, BuildingRatingTextBox, BuildingCategoryComboBox))
            {
                MessageBox.Show("Incorrect values. Fix it and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuildingAdded?.Invoke(this, new BuildingAddedEventArgs(_build));
            Close();
        }

        private void BuildingCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _build.Category = BuildingCategoryComboBox.Items[BuildingCategoryComboBox.SelectedIndex].ToString();
                BuildingCategoryComboBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingCategoryComboBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
