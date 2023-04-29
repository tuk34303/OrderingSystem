namespace OrderingSystem
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpModifyOrder = new System.Windows.Forms.GroupBox();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSelectOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.lblEntrees = new System.Windows.Forms.Label();
            this.lblAppetizers = new System.Windows.Forms.Label();
            this.grpNewOrder = new System.Windows.Forms.GroupBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodiumContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderingSystemDataSet = new OrderingSystem.OrderingSystemDataSet();
            this.menuItemTableAdapter = new OrderingSystem.OrderingSystemDataSetTableAdapters.menuItemTableAdapter();
            this.lstMenu = new System.Windows.Forms.ListView();
            this.picBeverage = new System.Windows.Forms.PictureBox();
            this.picDessert = new System.Windows.Forms.PictureBox();
            this.picEntree = new System.Windows.Forms.PictureBox();
            this.picAppetizer = new System.Windows.Forms.PictureBox();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.nutrientIbl = new System.Windows.Forms.Label();
            this.grpModifyOrder.SuspendLayout();
            this.grpNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModifyOrder
            // 
            this.grpModifyOrder.Controls.Add(this.btnCancelChanges);
            this.grpModifyOrder.Controls.Add(this.btnSaveChanges);
            this.grpModifyOrder.Location = new System.Drawing.Point(243, 512);
            this.grpModifyOrder.Margin = new System.Windows.Forms.Padding(4);
            this.grpModifyOrder.Name = "grpModifyOrder";
            this.grpModifyOrder.Padding = new System.Windows.Forms.Padding(4);
            this.grpModifyOrder.Size = new System.Drawing.Size(419, 68);
            this.grpModifyOrder.TabIndex = 17;
            this.grpModifyOrder.TabStop = false;
            this.grpModifyOrder.Visible = false;
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(229, 23);
            this.btnCancelChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(160, 37);
            this.btnCancelChanges.TabIndex = 1;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(28, 23);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 37);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Order Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSelectOrder
            // 
            this.btnSelectOrder.Location = new System.Drawing.Point(340, 448);
            this.btnSelectOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOrder.Name = "btnSelectOrder";
            this.btnSelectOrder.Size = new System.Drawing.Size(208, 37);
            this.btnSelectOrder.TabIndex = 30;
            this.btnSelectOrder.Text = "Find Order To Modify";
            this.btnSelectOrder.UseVisualStyleBackColor = true;
            this.btnSelectOrder.Click += new System.EventHandler(this.btnSelectOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(709, 126);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(160, 37);
            this.btnRemoveItem.TabIndex = 29;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(705, 190);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(68, 17);
            this.lblTable.TabIndex = 28;
            this.lblTable.Text = "Table #:";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(709, 209);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(68, 22);
            this.txtTable.TabIndex = 27;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(340, 396);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(208, 37);
            this.btnViewOrder.TabIndex = 26;
            this.btnViewOrder.Text = "View Current Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(709, 81);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(160, 37);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverages.Location = new System.Drawing.Point(12, 448);
            this.lblBeverages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(85, 17);
            this.lblBeverages.TabIndex = 25;
            this.lblBeverages.Text = "Beverages";
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesserts.Location = new System.Drawing.Point(12, 319);
            this.lblDesserts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(72, 17);
            this.lblDesserts.TabIndex = 24;
            this.lblDesserts.Text = "Desserts";
            // 
            // lblEntrees
            // 
            this.lblEntrees.AutoSize = true;
            this.lblEntrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrees.Location = new System.Drawing.Point(16, 190);
            this.lblEntrees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrees.Name = "lblEntrees";
            this.lblEntrees.Size = new System.Drawing.Size(64, 17);
            this.lblEntrees.TabIndex = 23;
            this.lblEntrees.Text = "Entrees";
            // 
            // lblAppetizers
            // 
            this.lblAppetizers.AutoSize = true;
            this.lblAppetizers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppetizers.Location = new System.Drawing.Point(16, 62);
            this.lblAppetizers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppetizers.Name = "lblAppetizers";
            this.lblAppetizers.Size = new System.Drawing.Size(85, 17);
            this.lblAppetizers.TabIndex = 22;
            this.lblAppetizers.Text = "Appetizers";
            // 
            // grpNewOrder
            // 
            this.grpNewOrder.Controls.Add(this.btnCancelOrder);
            this.grpNewOrder.Controls.Add(this.btnSubmitOrder);
            this.grpNewOrder.Location = new System.Drawing.Point(243, 576);
            this.grpNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.grpNewOrder.Name = "grpNewOrder";
            this.grpNewOrder.Padding = new System.Windows.Forms.Padding(4);
            this.grpNewOrder.Size = new System.Drawing.Size(419, 68);
            this.grpNewOrder.TabIndex = 15;
            this.grpNewOrder.TabStop = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(229, 23);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(160, 37);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(28, 23);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(160, 37);
            this.btnSubmitOrder.TabIndex = 0;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // dataGridItems
            // 
            this.dataGridItems.AutoGenerateColumns = false;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.carbsDataGridViewTextBoxColumn,
            this.fatsDataGridViewTextBoxColumn,
            this.proteinsDataGridViewTextBoxColumn,
            this.sodiumContentDataGridViewTextBoxColumn,
            this.ingredientsDataGridViewTextBoxColumn,
            this.allergyInformationDataGridViewTextBoxColumn});
            this.dataGridItems.DataSource = this.menuItemBindingSource;
            this.dataGridItems.Location = new System.Drawing.Point(185, 81);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersWidth = 51;
            this.dataGridItems.RowTemplate.Height = 24;
            this.dataGridItems.Size = new System.Drawing.Size(492, 249);
            this.dataGridItems.TabIndex = 33;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.Width = 125;
            // 
            // carbsDataGridViewTextBoxColumn
            // 
            this.carbsDataGridViewTextBoxColumn.DataPropertyName = "Carbs";
            this.carbsDataGridViewTextBoxColumn.HeaderText = "Carbs";
            this.carbsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carbsDataGridViewTextBoxColumn.Name = "carbsDataGridViewTextBoxColumn";
            this.carbsDataGridViewTextBoxColumn.Width = 125;
            // 
            // fatsDataGridViewTextBoxColumn
            // 
            this.fatsDataGridViewTextBoxColumn.DataPropertyName = "Fats";
            this.fatsDataGridViewTextBoxColumn.HeaderText = "Fats";
            this.fatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatsDataGridViewTextBoxColumn.Name = "fatsDataGridViewTextBoxColumn";
            this.fatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // proteinsDataGridViewTextBoxColumn
            // 
            this.proteinsDataGridViewTextBoxColumn.DataPropertyName = "Proteins";
            this.proteinsDataGridViewTextBoxColumn.HeaderText = "Proteins";
            this.proteinsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proteinsDataGridViewTextBoxColumn.Name = "proteinsDataGridViewTextBoxColumn";
            this.proteinsDataGridViewTextBoxColumn.Width = 125;
            // 
            // sodiumContentDataGridViewTextBoxColumn
            // 
            this.sodiumContentDataGridViewTextBoxColumn.DataPropertyName = "SodiumContent";
            this.sodiumContentDataGridViewTextBoxColumn.HeaderText = "SodiumContent";
            this.sodiumContentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sodiumContentDataGridViewTextBoxColumn.Name = "sodiumContentDataGridViewTextBoxColumn";
            this.sodiumContentDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingredientsDataGridViewTextBoxColumn
            // 
            this.ingredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients";
            this.ingredientsDataGridViewTextBoxColumn.HeaderText = "Ingredients";
            this.ingredientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientsDataGridViewTextBoxColumn.Name = "ingredientsDataGridViewTextBoxColumn";
            this.ingredientsDataGridViewTextBoxColumn.Width = 125;
            // 
            // allergyInformationDataGridViewTextBoxColumn
            // 
            this.allergyInformationDataGridViewTextBoxColumn.DataPropertyName = "AllergyInformation";
            this.allergyInformationDataGridViewTextBoxColumn.HeaderText = "AllergyInformation";
            this.allergyInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allergyInformationDataGridViewTextBoxColumn.Name = "allergyInformationDataGridViewTextBoxColumn";
            this.allergyInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuItemBindingSource
            // 
            this.menuItemBindingSource.DataMember = "menuItem";
            this.menuItemBindingSource.DataSource = this.orderingSystemDataSet;
            // 
            // orderingSystemDataSet
            // 
            this.orderingSystemDataSet.DataSetName = "OrderingSystemDataSet";
            this.orderingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemTableAdapter
            // 
            this.menuItemTableAdapter.ClearBeforeFill = true;
            // 
            // lstMenu
            // 
            this.lstMenu.HideSelection = false;
            this.lstMenu.Location = new System.Drawing.Point(709, 480);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(121, 97);
            this.lstMenu.TabIndex = 34;
            this.lstMenu.UseCompatibleStateImageBehavior = false;
            // 
            // picBeverage
            // 
            this.picBeverage.Image = global::OrderingSystem.Properties.Resources.drinks;
            this.picBeverage.Location = new System.Drawing.Point(16, 468);
            this.picBeverage.Margin = new System.Windows.Forms.Padding(4);
            this.picBeverage.Name = "picBeverage";
            this.picBeverage.Size = new System.Drawing.Size(133, 97);
            this.picBeverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeverage.TabIndex = 21;
            this.picBeverage.TabStop = false;
            this.picBeverage.Click += new System.EventHandler(this.picBeverage_Click);
            // 
            // picDessert
            // 
            this.picDessert.Image = global::OrderingSystem.Properties.Resources.dessert;
            this.picDessert.Location = new System.Drawing.Point(16, 336);
            this.picDessert.Margin = new System.Windows.Forms.Padding(4);
            this.picDessert.Name = "picDessert";
            this.picDessert.Size = new System.Drawing.Size(133, 97);
            this.picDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDessert.TabIndex = 20;
            this.picDessert.TabStop = false;
            this.picDessert.Click += new System.EventHandler(this.picDessert_Click);
            // 
            // picEntree
            // 
            this.picEntree.Image = global::OrderingSystem.Properties.Resources.entree;
            this.picEntree.Location = new System.Drawing.Point(16, 209);
            this.picEntree.Margin = new System.Windows.Forms.Padding(4);
            this.picEntree.Name = "picEntree";
            this.picEntree.Size = new System.Drawing.Size(133, 97);
            this.picEntree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntree.TabIndex = 19;
            this.picEntree.TabStop = false;
            this.picEntree.Click += new System.EventHandler(this.picEntree_Click);
            // 
            // picAppetizer
            // 
            this.picAppetizer.Image = global::OrderingSystem.Properties.Resources.appetizer;
            this.picAppetizer.Location = new System.Drawing.Point(16, 81);
            this.picAppetizer.Margin = new System.Windows.Forms.Padding(4);
            this.picAppetizer.Name = "picAppetizer";
            this.picAppetizer.Size = new System.Drawing.Size(133, 97);
            this.picAppetizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppetizer.TabIndex = 16;
            this.picAppetizer.TabStop = false;
            this.picAppetizer.Click += new System.EventHandler(this.picAppetizer_Click);
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(837, 359);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(133, 63);
            this.btnViewItem.TabIndex = 35;
            this.btnViewItem.Text = "View Item Nutrients";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // nutrientIbl
            // 
            this.nutrientIbl.AutoSize = true;
            this.nutrientIbl.Location = new System.Drawing.Point(727, 288);
            this.nutrientIbl.Name = "nutrientIbl";
            this.nutrientIbl.Size = new System.Drawing.Size(293, 68);
            this.nutrientIbl.TabIndex = 36;
            this.nutrientIbl.Text = "select row of the Item of your choice, that you\r\nwant to view its numerical nutri" +
    "onal values,\r\n then click the \"View Item Nutrients\" \r\nbutton";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 662);
            this.Controls.Add(this.nutrientIbl);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.dataGridItems);
            this.Controls.Add(this.grpModifyOrder);
            this.Controls.Add(this.btnSelectOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblBeverages);
            this.Controls.Add(this.lblDesserts);
            this.Controls.Add(this.lblEntrees);
            this.Controls.Add(this.lblAppetizers);
            this.Controls.Add(this.picBeverage);
            this.Controls.Add(this.picDessert);
            this.Controls.Add(this.picEntree);
            this.Controls.Add(this.picAppetizer);
            this.Controls.Add(this.grpNewOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpModifyOrder.ResumeLayout(false);
            this.grpNewOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppetizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpModifyOrder;
        internal System.Windows.Forms.Button btnCancelChanges;
        internal System.Windows.Forms.Button btnSaveChanges;
        internal System.Windows.Forms.Button btnSelectOrder;
        internal System.Windows.Forms.Button btnRemoveItem;
        internal System.Windows.Forms.Label lblTable;
        internal System.Windows.Forms.TextBox txtTable;
        internal System.Windows.Forms.Button btnViewOrder;
        internal System.Windows.Forms.Button btnAddToOrder;
        internal System.Windows.Forms.Label lblBeverages;
        internal System.Windows.Forms.Label lblDesserts;
        internal System.Windows.Forms.Label lblEntrees;
        internal System.Windows.Forms.Label lblAppetizers;
        internal System.Windows.Forms.PictureBox picBeverage;
        internal System.Windows.Forms.PictureBox picDessert;
        internal System.Windows.Forms.PictureBox picEntree;
        internal System.Windows.Forms.PictureBox picAppetizer;
        internal System.Windows.Forms.GroupBox grpNewOrder;
        internal System.Windows.Forms.Button btnCancelOrder;
        internal System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.DataGridView dataGridItems;
        private OrderingSystemDataSet orderingSystemDataSet;
        private System.Windows.Forms.BindingSource menuItemBindingSource;
        private OrderingSystemDataSetTableAdapters.menuItemTableAdapter menuItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodiumContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView lstMenu;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Label nutrientIbl;
    }
}