namespace OrderingSystem
{
    partial class frmViewOrders
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
            this.btnViewBill = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListView();
            this.colOrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBillSubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompletionStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriorityStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.completeIbl = new System.Windows.Forms.Label();
            this.comboPriorityBox = new System.Windows.Forms.ComboBox();
            this.comboOrderBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(353, 384);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(160, 37);
            this.btnViewBill.TabIndex = 17;
            this.btnViewBill.Text = "View Bill";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(119, 384);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(160, 37);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Close";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(584, 384);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 37);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderNumber,
            this.colTable,
            this.colTime,
            this.colBillSubTotal,
            this.CompletionStatus,
            this.PriorityStatus});
            this.lstOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.GridLines = true;
            this.lstOrders.HideSelection = false;
            this.lstOrders.Location = new System.Drawing.Point(13, 41);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrders.MultiSelect = false;
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(781, 275);
            this.lstOrders.TabIndex = 14;
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.Text = "Order #";
            this.colOrderNumber.Width = 158;
            // 
            // colTable
            // 
            this.colTable.Text = "Table #";
            this.colTable.Width = 72;
            // 
            // colTime
            // 
            this.colTime.Text = "Order Time";
            this.colTime.Width = 113;
            // 
            // colBillSubTotal
            // 
            this.colBillSubTotal.Text = "Bill SubTotal";
            this.colBillSubTotal.Width = 122;
            // 
            // CompletionStatus
            // 
            this.CompletionStatus.Text = "CompletionStatus";
            this.CompletionStatus.Width = 120;
            // 
            // PriorityStatus
            // 
            this.PriorityStatus.Text = "Priority";
            this.PriorityStatus.Width = 100;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(936, 414);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(98, 52);
            this.btnCompleteOrder.TabIndex = 18;
            this.btnCompleteOrder.Text = "Set Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(936, 307);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(98, 51);
            this.btnPriority.TabIndex = 19;
            this.btnPriority.Text = "Set Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // completeIbl
            // 
            this.completeIbl.AutoSize = true;
            this.completeIbl.Location = new System.Drawing.Point(282, 324);
            this.completeIbl.Name = "completeIbl";
            this.completeIbl.Size = new System.Drawing.Size(0, 17);
            this.completeIbl.TabIndex = 20;
            // 
            // comboPriorityBox
            // 
            this.comboPriorityBox.FormattingEnabled = true;
            this.comboPriorityBox.Items.AddRange(new object[] {
            "High ",
            "Medium ",
            "Low "});
            this.comboPriorityBox.Location = new System.Drawing.Point(911, 364);
            this.comboPriorityBox.Name = "comboPriorityBox";
            this.comboPriorityBox.Size = new System.Drawing.Size(136, 24);
            this.comboPriorityBox.TabIndex = 21;
            // 
            // comboOrderBox
            // 
            this.comboOrderBox.FormattingEnabled = true;
            this.comboOrderBox.Items.AddRange(new object[] {
            "Order Complete",
            "Order Incomplete "});
            this.comboOrderBox.Location = new System.Drawing.Point(926, 472);
            this.comboOrderBox.Name = "comboOrderBox";
            this.comboOrderBox.Size = new System.Drawing.Size(121, 24);
            this.comboOrderBox.TabIndex = 22;
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 550);
            this.Controls.Add(this.comboOrderBox);
            this.Controls.Add(this.comboPriorityBox);
            this.Controls.Add(this.completeIbl);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstOrders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewOrders";
            this.Load += new System.EventHandler(this.frmViewOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnViewBill;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ListView lstOrders;
        internal System.Windows.Forms.ColumnHeader colOrderNumber;
        internal System.Windows.Forms.ColumnHeader colTable;
        internal System.Windows.Forms.ColumnHeader colTime;
        internal System.Windows.Forms.ColumnHeader colBillSubTotal;
        private System.Windows.Forms.ColumnHeader CompletionStatus;
        private System.Windows.Forms.ColumnHeader PriorityStatus;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Label completeIbl;
        private System.Windows.Forms.ComboBox comboPriorityBox;
        private System.Windows.Forms.ComboBox comboOrderBox;
    }
}