using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace practicum_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Колекція для зберігання товарів (і їх кількості)
        private BindingList<Item> inventory = new BindingList<Item>();

        // Клас Item для зберігання інформації про товар
        public class Item
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

            public Item(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }

            public decimal TotalCost()
            {
                return Quantity * Price;
            }

            public override string ToString()
            {
                return string.Format("{0}: {1} @ {2:C} each, Total: {3:C}", Name, Quantity, Price, TotalCost());
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text; // Використовуємо введену назву товару
            int quantity;
            decimal price;

            // Перевіряємо, чи текст у txtQuantity можна перетворити на ціле число та чи є введена ціна
            if (int.TryParse(txtQuantity.Text, out quantity) && decimal.TryParse(txtPrice.Text, out price))
            {
                // Додаємо елемент до списку
                inventory.Add(new Item(itemName, quantity, price));
                lstInventory.Items.Add(inventory[inventory.Count - 1]);

                // Оновлюємо підсумки
                UpdateSummary();
            }
            else
            {
                // Виводимо повідомлення про помилку введення
                MessageBox.Show("Please enter valid quantity and price.");
            }
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            // Відображаємо кількість елементів у списку
            MessageBox.Show("Total items in inventory: " + inventory.Count);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Якщо вибраний елемент у списку, видаляємо його
            if (lstInventory.SelectedItem != null)
            {
                inventory.RemoveAt(lstInventory.SelectedIndex);
                lstInventory.Items.Remove(lstInventory.SelectedItem);
                UpdateSummary();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Якщо вибраний елемент у списку, редагуємо його
            if (lstInventory.SelectedItem != null)
            {
                var selectedItem = (Item)lstInventory.SelectedItem;
                selectedItem.Name = txtItemName.Text; // Відновлюємо нові значення з текстових полів
                selectedItem.Quantity = int.Parse(txtQuantity.Text);
                selectedItem.Price = decimal.Parse(txtPrice.Text);

                // Оновлюємо список
                lstInventory.Items[lstInventory.SelectedIndex] = selectedItem;

                UpdateSummary();
            }
        }

        private void UpdateSummary()
        {
            int totalItems = 0;
            decimal totalCost = 0;

            // Обчислюємо кількість і сумарну вартість товару
            foreach (var item in inventory)
            {
                totalItems += item.Quantity;
                totalCost += item.TotalCost();
            }

            // Оновлюємо підсумки на формі
            lblTotalItems.Text = string.Format("Total Items: {0}", totalItems);
            lblTotalCost.Text = string.Format("Total Cost: {0:C}", totalCost);
        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Якщо елемент вибраний в списку, заповнюємо поля для редагування
            if (lstInventory.SelectedItem != null)
            {
                var selectedItem = (Item)lstInventory.SelectedItem;
                txtItemName.Text = selectedItem.Name;
                txtQuantity.Text = selectedItem.Quantity.ToString();
                txtPrice.Text = selectedItem.Price.ToString("F2");
            }
        }
    }
}
