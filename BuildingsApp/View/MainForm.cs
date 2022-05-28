using BuildingsApp.Model;
using BuildingsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Environment;

namespace BuildingsApp.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Окно добавления строения.
        /// </summary>
        private AddBuildingForm _buildingForm;

        /// <summary>
        /// Коллекция строений.
        /// </summary>
        private List<Building> _buildings;

        /// <summary>
        /// Текущие строение.
        /// </summary>
        private Building _currentBuilding;

        /// <summary>
        /// Путь до файла данных.
        /// </summary>
        private readonly string _appDataFolder = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}\BuildingApp\data.json";

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                BuildingCategoryComboBox.Items.Add(item);
            }

            _buildings = Serializer.Deserialize(_appDataFolder);
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает поля для вывода информации.
        /// </summary>
        private void ClearInfo()
        {
            BuildingsListBox.SelectedIndex = -1;
            BuildingCategoryComboBox.SelectedIndex = -1;
            BuildingAddressTextBox.Clear();
            BuildingNameTextBox.Clear();
            BuildingRatingTextBox.Clear();
        }

        /// <summary>
        /// Обновляет данные в списке BuildingsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            BuildingsListBox.Items.Clear();

            var orderedListBuilding = from building in _buildings
                                      orderby building.Category, building.Name
                                      select building;
            _buildings = orderedListBuilding.ToList();

            foreach (var building in _buildings)
            {
                BuildingsListBox.Items.Add($"{building.Category} - {building.Name}");
            }

            BuildingsListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Изменяет имя строения.
        /// </summary>
        private void EditBuildingNameTextBox()
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Name = BuildingNameTextBox.Text;
                BuildingNameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменяет адрес строения.
        /// </summary>
        private void EditBuildingAddressTextBox()
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Address = BuildingAddressTextBox.Text;
                BuildingAddressTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingAddressTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменяет категорию строения.
        /// </summary>
        private void EditBuildingCategoryComboBox()
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            if (BuildingCategoryComboBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Category = BuildingCategoryComboBox.SelectedItem.ToString();
                BuildingCategoryComboBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingCategoryComboBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменяет рейтинг строения.
        /// </summary>
        private void EditBuildingRatingTextBox()
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Rating = int.Parse(BuildingRatingTextBox.Text);
                BuildingRatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingRatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _buildingForm = new AddBuildingForm();
            _buildingForm.BuildingAdded += AddBuildingForm_BuildingAdded;
            _buildingForm.ShowDialog();
            Serializer.Serialize(_appDataFolder, _buildings);
        }

        private void AddBuildingForm_BuildingAdded(object sender, BuildingAddedEventArgs args)
        {
            _buildings.Add(args.Build);
            UpdateListBox(0);
        }

        private void BuildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            _currentBuilding = _buildings[BuildingsListBox.SelectedIndex];
            BuildingNameTextBox.Text = _currentBuilding.Name;
            BuildingAddressTextBox.Text = _currentBuilding.Address;
            BuildingCategoryComboBox.Text = _currentBuilding.Category;
            BuildingRatingTextBox.Text = _currentBuilding.Rating.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            _buildings.RemoveAt(BuildingsListBox.SelectedIndex);

            if (_buildings.Count == 0) ClearInfo();

            UpdateListBox(-1);

            Serializer.Serialize(_appDataFolder, _buildings);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditBuildingAddressTextBox();
            EditBuildingCategoryComboBox();
            EditBuildingNameTextBox();
            EditBuildingRatingTextBox();
            UpdateListBox(0);
            Serializer.Serialize(_appDataFolder, _buildings);
        }

        private void BuildingNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingsListBox.SelectedIndex == -1) return;
            try
            {
                Validator.AssertValueInRange(BuildingNameTextBox.Text.Length, 1, 200, nameof(Name));
                BuildingNameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void BuildingRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertValueInRange(int.Parse(BuildingRatingTextBox.Text), 0, 5, nameof(Name));
                BuildingRatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingRatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        private void BuildingAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingsListBox.SelectedIndex == -1) return;

            try
            {
                Validator.AssertValueInRange(BuildingAddressTextBox.Text.Length, 1, 200, nameof(Name));
                BuildingAddressTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                BuildingAddressTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_24x24_black;
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_24x24;
        }
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = BuildingsApp.Properties.Resources.add_24x24_black;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = BuildingsApp.Properties.Resources.add_24x24;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = BuildingsApp.Properties.Resources.cross_circle_24x24_black;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = BuildingsApp.Properties.Resources.cross_circle_24x24;
        }
    }
}