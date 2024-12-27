namespace practicum_lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnRemoveItem; // Кнопка для видалення
        private System.Windows.Forms.Button btnEditItem;   // Кнопка для редагування
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;       // Лейбл для ціни
        private System.Windows.Forms.Label lblTotalItems; // Лейбл для відображення загальної кількості товарів
        private System.Windows.Forms.Label lblTotalCost;  // Лейбл для відображення загальної вартості
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice; // Поле для введення ціни
        private System.Windows.Forms.ListBox lstInventory;

        private void InitializeComponent()
        {
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(30, 150);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 30);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(150, 150);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(100, 30);
            this.btnCheckStock.TabIndex = 1;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);

            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(30, 200);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(150, 200);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(100, 30);
            this.btnEditItem.TabIndex = 3;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);

            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(30, 30);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(63, 13);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name:";

            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(150, 27);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 5;

            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(30, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";

            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(150, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;

            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 107);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;

            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(30, 240);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(220, 95);
            this.lstInventory.TabIndex = 10;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);

            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(30, 340);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(69, 13);
            this.lblTotalItems.TabIndex = 11;
            this.lblTotalItems.Text = "Total Items: 0";

            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(150, 340);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(69, 13);
            this.lblTotalCost.TabIndex = 12;
            this.lblTotalCost.Text = "Total Cost: 0";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnAddItem);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
