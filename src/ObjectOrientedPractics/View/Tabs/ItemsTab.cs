using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            if (Serializer.IsFile("Items"))
            {
                _items = Serializer.LoadFromFile<Item>("Items");

                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }

                ItemsListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обновляет все текстовые поля значениями выбранного товара.
        /// </summary>
        private void UpdateTextBoxes(Item item)
        {
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            IdTextBox.Text = item.Id.ToString();
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            IdTextBox.Clear();
        }

        /// <summary>
        /// Сохраняет данные о товарах.
        /// </summary>
        public void SerializeData()
        {
            Serializer.SaveToFile("Items", _items);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("None", "None", 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            ItemsListBox.SelectedIndex = _items.Count - 1;
            UpdateTextBoxes(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;
            int index = ItemsListBox.SelectedIndex;
            ItemsListBox.Items.RemoveAt(index);
            _items.RemoveAt(index);
            ItemsListBox.SelectedIndex = _items.Count > 0 ? 0 : -1;
            UpdateTextBoxes(_currentItem);
            if (ItemsListBox.Items.Count == 0) ClearTextBoxes();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1) return;
            _currentItem = _items[index];
            UpdateTextBoxes(_currentItem);
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = AppColor.ErrorBackColor;
                if (_items.Count == 0) CostTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.
                    Items[_items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorBackColor;
                if (_items.Count == 0) NameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }
    }
}
