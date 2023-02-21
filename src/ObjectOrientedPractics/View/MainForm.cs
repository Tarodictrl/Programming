﻿using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = Serializer.Deserialize();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
            PriorityOrdersTab.Items = _store.Items;
            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;
            Serializer.Serialize(_store);
        }

        private void ItemsTab_ItemsChanged(object sender, System.EventArgs args)
        {
            CartsTab.Items = ItemsTab.Items;
            CartsTab.Customers = CustomersTab.Customers;
            OrdersTab.Customers = CartsTab.Customers;
            OrdersTab.RefreshData();
            CartsTab.RefreshData();
        }

        
    }
}
