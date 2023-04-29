namespace OrderingSystem
{
    partial class frmModifyMenu
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.removeItemDataGrid = new System.Windows.Forms.DataGridView();
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
            this.orderingSystemDataSet1 = new OrderingSystem.OrderingSystemDataSet1();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboCategoryList = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lstMenu = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.allergyInfotxt = new System.Windows.Forms.TextBox();
            this.ingredientstxt = new System.Windows.Forms.TextBox();
            this.sodiumtxt = new System.Windows.Forms.TextBox();
            this.proteintxt = new System.Windows.Forms.TextBox();
            this.fatstxt = new System.Windows.Forms.TextBox();
            this.carbstxt = new System.Windows.Forms.TextBox();
            this.caloriestxt = new System.Windows.Forms.TextBox();
            this.allergyIbl = new System.Windows.Forms.Label();
            this.ingredientIbl = new System.Windows.Forms.Label();
            this.sodiumIbl = new System.Windows.Forms.Label();
            this.proteinIbl = new System.Windows.Forms.Label();
            this.fatsIbl = new System.Windows.Forms.Label();
            this.CarbsIbl = new System.Windows.Forms.Label();
            this.caloriesIbl = new System.Windows.Forms.Label();
            this.menuItemTableAdapter = new OrderingSystem.OrderingSystemDataSet1TableAdapters.menuItemTableAdapter();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeItemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingSystemDataSet1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.removeItemDataGrid);
            this.GroupBox2.Controls.Add(this.btnRemove);
            this.GroupBox2.Controls.Add(this.cboCategoryList);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Location = new System.Drawing.Point(16, 286);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(448, 273);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Remove Menu Item";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // removeItemDataGrid
            // 
            this.removeItemDataGrid.AutoGenerateColumns = false;
            this.removeItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.removeItemDataGrid.DataSource = this.menuItemBindingSource;
            this.removeItemDataGrid.Location = new System.Drawing.Point(33, 81);
            this.removeItemDataGrid.Name = "removeItemDataGrid";
            this.removeItemDataGrid.RowHeadersWidth = 51;
            this.removeItemDataGrid.RowTemplate.Height = 24;
            this.removeItemDataGrid.Size = new System.Drawing.Size(375, 150);
            this.removeItemDataGrid.TabIndex = 8;
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
            this.menuItemBindingSource.DataSource = this.orderingSystemDataSet1;
            // 
            // orderingSystemDataSet1
            // 
            this.orderingSystemDataSet1.DataSetName = "OrderingSystemDataSet1";
            this.orderingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(131, 238);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 28);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove From Menu";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboCategoryList
            // 
            this.cboCategoryList.FormattingEnabled = true;
            this.cboCategoryList.Items.AddRange(new object[] {
            "Appetizers",
            "Dessert",
            "Drink",
            "Entree",
            "Salad"});
            this.cboCategoryList.Location = new System.Drawing.Point(131, 41);
            this.cboCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoryList.Name = "cboCategoryList";
            this.cboCategoryList.Size = new System.Drawing.Size(160, 24);
            this.cboCategoryList.TabIndex = 5;
            this.cboCategoryList.SelectedIndexChanged += new System.EventHandler(this.cboCategoryList_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(53, 41);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 17);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Category:";
            // 
            // lstMenu
            // 
            this.lstMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Price});
            this.lstMenu.GridLines = true;
            this.lstMenu.HideSelection = false;
            this.lstMenu.Location = new System.Drawing.Point(537, 487);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(4);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(388, 118);
            this.lstMenu.TabIndex = 6;
            this.lstMenu.UseCompatibleStateImageBehavior = false;
            this.lstMenu.View = System.Windows.Forms.View.Details;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 207;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 81;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAddToMenu);
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.lblPrice);
            this.GroupBox1.Controls.Add(this.txtDesc);
            this.GroupBox1.Controls.Add(this.lblDesc);
            this.GroupBox1.Controls.Add(this.cboCategory);
            this.GroupBox1.Controls.Add(this.lblCategory);
            this.GroupBox1.Location = new System.Drawing.Point(16, 32);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(542, 259);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add New Menu Item";
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Location = new System.Drawing.Point(131, 188);
            this.btnAddToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(161, 28);
            this.btnAddToMenu.TabIndex = 4;
            this.btnAddToMenu.Text = "Add to Menu";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            this.btnAddToMenu.Click += new System.EventHandler(this.btnAddToMenu_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 133);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(91, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(77, 133);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(132, 87);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(259, 22);
            this.txtDesc.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(39, 87);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(83, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Appetizers",
            "Dessert",
            "Drink",
            "Entree",
            "Salad "});
            this.cboCategory.Location = new System.Drawing.Point(131, 41);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(160, 24);
            this.cboCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(53, 41);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // allergyInfotxt
            // 
            this.allergyInfotxt.Location = new System.Drawing.Point(781, 385);
            this.allergyInfotxt.Name = "allergyInfotxt";
            this.allergyInfotxt.Size = new System.Drawing.Size(100, 22);
            this.allergyInfotxt.TabIndex = 18;
            // 
            // ingredientstxt
            // 
            this.ingredientstxt.Location = new System.Drawing.Point(781, 314);
            this.ingredientstxt.Name = "ingredientstxt";
            this.ingredientstxt.Size = new System.Drawing.Size(100, 22);
            this.ingredientstxt.TabIndex = 17;
            // 
            // sodiumtxt
            // 
            this.sodiumtxt.Location = new System.Drawing.Point(781, 253);
            this.sodiumtxt.Name = "sodiumtxt";
            this.sodiumtxt.Size = new System.Drawing.Size(100, 22);
            this.sodiumtxt.TabIndex = 16;
            // 
            // proteintxt
            // 
            this.proteintxt.Location = new System.Drawing.Point(781, 199);
            this.proteintxt.Name = "proteintxt";
            this.proteintxt.Size = new System.Drawing.Size(100, 22);
            this.proteintxt.TabIndex = 15;
            // 
            // fatstxt
            // 
            this.fatstxt.Location = new System.Drawing.Point(781, 145);
            this.fatstxt.Name = "fatstxt";
            this.fatstxt.Size = new System.Drawing.Size(100, 22);
            this.fatstxt.TabIndex = 14;
            // 
            // carbstxt
            // 
            this.carbstxt.Location = new System.Drawing.Point(781, 96);
            this.carbstxt.Name = "carbstxt";
            this.carbstxt.Size = new System.Drawing.Size(100, 22);
            this.carbstxt.TabIndex = 13;
            // 
            // caloriestxt
            // 
            this.caloriestxt.Location = new System.Drawing.Point(781, 44);
            this.caloriestxt.Name = "caloriestxt";
            this.caloriestxt.Size = new System.Drawing.Size(100, 22);
            this.caloriestxt.TabIndex = 12;
            // 
            // allergyIbl
            // 
            this.allergyIbl.AutoSize = true;
            this.allergyIbl.Location = new System.Drawing.Point(668, 390);
            this.allergyIbl.Name = "allergyIbl";
            this.allergyIbl.Size = new System.Drawing.Size(82, 17);
            this.allergyIbl.TabIndex = 11;
            this.allergyIbl.Text = "Allergy Info:";
            // 
            // ingredientIbl
            // 
            this.ingredientIbl.AutoSize = true;
            this.ingredientIbl.Location = new System.Drawing.Point(668, 314);
            this.ingredientIbl.Name = "ingredientIbl";
            this.ingredientIbl.Size = new System.Drawing.Size(82, 17);
            this.ingredientIbl.TabIndex = 10;
            this.ingredientIbl.Text = "Ingredients:";
            // 
            // sodiumIbl
            // 
            this.sodiumIbl.AutoSize = true;
            this.sodiumIbl.Location = new System.Drawing.Point(661, 256);
            this.sodiumIbl.Name = "sodiumIbl";
            this.sodiumIbl.Size = new System.Drawing.Size(112, 17);
            this.sodiumIbl.TabIndex = 9;
            this.sodiumIbl.Text = "Sodium Content;";
            // 
            // proteinIbl
            // 
            this.proteinIbl.AutoSize = true;
            this.proteinIbl.Location = new System.Drawing.Point(675, 202);
            this.proteinIbl.Name = "proteinIbl";
            this.proteinIbl.Size = new System.Drawing.Size(56, 17);
            this.proteinIbl.TabIndex = 8;
            this.proteinIbl.Text = "protein:";
            // 
            // fatsIbl
            // 
            this.fatsIbl.AutoSize = true;
            this.fatsIbl.Location = new System.Drawing.Point(668, 150);
            this.fatsIbl.Name = "fatsIbl";
            this.fatsIbl.Size = new System.Drawing.Size(35, 17);
            this.fatsIbl.TabIndex = 7;
            this.fatsIbl.Text = "Fats";
            // 
            // CarbsIbl
            // 
            this.CarbsIbl.AutoSize = true;
            this.CarbsIbl.Location = new System.Drawing.Point(668, 96);
            this.CarbsIbl.Name = "CarbsIbl";
            this.CarbsIbl.Size = new System.Drawing.Size(105, 17);
            this.CarbsIbl.TabIndex = 6;
            this.CarbsIbl.Text = "Carbohydrates:";
            // 
            // caloriesIbl
            // 
            this.caloriesIbl.AutoSize = true;
            this.caloriesIbl.Location = new System.Drawing.Point(668, 47);
            this.caloriesIbl.Name = "caloriesIbl";
            this.caloriesIbl.Size = new System.Drawing.Size(63, 17);
            this.caloriesIbl.TabIndex = 5;
            this.caloriesIbl.Text = "Calories:";
            // 
            // menuItemTableAdapter
            // 
            this.menuItemTableAdapter.ClearBeforeFill = true;
            // 
            // frmModifyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 667);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.allergyInfotxt);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.allergyIbl);
            this.Controls.Add(this.ingredientstxt);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.sodiumtxt);
            this.Controls.Add(this.ingredientIbl);
            this.Controls.Add(this.caloriesIbl);
            this.Controls.Add(this.proteintxt);
            this.Controls.Add(this.caloriestxt);
            this.Controls.Add(this.sodiumIbl);
            this.Controls.Add(this.fatstxt);
            this.Controls.Add(this.CarbsIbl);
            this.Controls.Add(this.carbstxt);
            this.Controls.Add(this.proteinIbl);
            this.Controls.Add(this.fatsIbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModifyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyMenu";
            this.Load += new System.EventHandler(this.frmModifyMenu_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeItemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingSystemDataSet1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ListView lstMenu;
        internal System.Windows.Forms.ColumnHeader Description;
        internal System.Windows.Forms.ColumnHeader Price;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.ComboBox cboCategoryList;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAddToMenu;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Label lblDesc;
        internal System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label sodiumIbl;
        private System.Windows.Forms.Label proteinIbl;
        private System.Windows.Forms.Label fatsIbl;
        private System.Windows.Forms.Label CarbsIbl;
        private System.Windows.Forms.Label caloriesIbl;
        private System.Windows.Forms.Label allergyIbl;
        private System.Windows.Forms.Label ingredientIbl;
        private System.Windows.Forms.TextBox allergyInfotxt;
        private System.Windows.Forms.TextBox ingredientstxt;
        private System.Windows.Forms.TextBox sodiumtxt;
        private System.Windows.Forms.TextBox proteintxt;
        private System.Windows.Forms.TextBox fatstxt;
        private System.Windows.Forms.TextBox carbstxt;
        private System.Windows.Forms.TextBox caloriestxt;
        private System.Windows.Forms.DataGridView removeItemDataGrid;
        private OrderingSystemDataSet1 orderingSystemDataSet1;
        private System.Windows.Forms.BindingSource menuItemBindingSource;
        private OrderingSystemDataSet1TableAdapters.menuItemTableAdapter menuItemTableAdapter;
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
        private System.Windows.Forms.Button btnSearch;
    }
}