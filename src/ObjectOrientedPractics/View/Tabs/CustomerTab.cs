using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CustomerTab()
        {
            InitializeComponent();

            if (Serializer.IsFile("Customers"))
            {
                _customers = Serializer.LoadFromFile<Customer>("Customers");

                foreach (var customer in _customers)
                {
                    CustomersListBox.Items.Add(customer.Fullname);
                }

                CustomersListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            IdTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в текст боксах.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateTextBoxes(Customer customer)
        {
            FullNameTextBox.Text = customer.Fullname;
            AddressTextBox.Text = customer.Address;
            IdTextBox.Text = customer.Id.ToString();
        }

        /// <summary>
        /// Сохраняет данные о товарах.
        /// </summary>
        public void SerializeData()
        {
            Serializer.SaveToFile("Customers", _customers);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None", "None");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.Fullname);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;

            int index = CustomersListBox.SelectedIndex;

            CustomersListBox.Items.RemoveAt(index);
            _customers.RemoveAt(index);

            CustomersListBox.SelectedIndex = _customers.Count > 0 ? 0 : -1;

            UpdateTextBoxes(_currentCustomer);

            if (CustomersListBox.Items.Count == 0) ClearTextBoxes();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = AppColor.NormalBackColor;
                _currentCustomer.Fullname = FullNameTextBox.Text;
                CustomersListBox.Items[_customers.IndexOf(_currentCustomer)] = _currentCustomer.Fullname;
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorBackColor;
                if (_customers.Count == 0) FullNameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColor.NormalBackColor;
                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch
            {
                AddressTextBox.BackColor = AppColor.ErrorBackColor;

                if (_customers.Count == 0) AddressTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _currentCustomer = _customers[index];

            UpdateTextBoxes(_currentCustomer);
        }
    }
}
