
namespace OrderingSystem
{
    partial class modifyItem
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
            this.menuDataGrid = new System.Windows.Forms.DataGridView();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.comboMod = new System.Windows.Forms.ComboBox();
            this.btnModItem = new System.Windows.Forms.Button();
            this.modIbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuDataGrid
            // 
            this.menuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGrid.Location = new System.Drawing.Point(52, 39);
            this.menuDataGrid.Name = "menuDataGrid";
            this.menuDataGrid.RowHeadersWidth = 51;
            this.menuDataGrid.RowTemplate.Height = 24;
            this.menuDataGrid.Size = new System.Drawing.Size(789, 259);
            this.menuDataGrid.TabIndex = 0;
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(500, 368);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(100, 22);
            this.txtMod.TabIndex = 1;
            // 
            // comboMod
            // 
            this.comboMod.FormattingEnabled = true;
            this.comboMod.Items.AddRange(new object[] {
            "Category",
            "Description",
            "Price"});
            this.comboMod.Location = new System.Drawing.Point(621, 366);
            this.comboMod.Name = "comboMod";
            this.comboMod.Size = new System.Drawing.Size(121, 24);
            this.comboMod.TabIndex = 2;
            // 
            // btnModItem
            // 
            this.btnModItem.Location = new System.Drawing.Point(555, 407);
            this.btnModItem.Name = "btnModItem";
            this.btnModItem.Size = new System.Drawing.Size(105, 44);
            this.btnModItem.TabIndex = 3;
            this.btnModItem.Text = "Modify";
            this.btnModItem.UseVisualStyleBackColor = true;
            this.btnModItem.Click += new System.EventHandler(this.btnModItem_Click);
            // 
            // modIbl
            // 
            this.modIbl.AutoSize = true;
            this.modIbl.Location = new System.Drawing.Point(12, 347);
            this.modIbl.Name = "modIbl";
            this.modIbl.Size = new System.Drawing.Size(344, 68);
            this.modIbl.TabIndex = 4;
            this.modIbl.Text = "Select Row of Item you want to modify\r\nThen use the combo box to select an aspect" +
    " \r\nabout the item and  enter in the textbox what\r\n you want to change it to and " +
    "click the \"Modify\" button";
            // 
            // modifyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 491);
            this.Controls.Add(this.modIbl);
            this.Controls.Add(this.btnModItem);
            this.Controls.Add(this.comboMod);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.menuDataGrid);
            this.Name = "modifyItem";
            this.Text = "modifyItem";
            this.Load += new System.EventHandler(this.modifyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuDataGrid;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.ComboBox comboMod;
        private System.Windows.Forms.Button btnModItem;
        private System.Windows.Forms.Label modIbl;
    }
}