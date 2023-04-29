using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class modifyItem : Form
    {
        public modifyItem()
        {
            InitializeComponent();
            this.FormClosed += modifyMenu_FormClosing;
        }

        private void modifyMenu_Load(object sender, EventArgs e)
        {
            DataTable menuTable = menuItemDatabase.loadFromMenuItemDatabase();
            BindingSource items = new BindingSource();
            items.DataSource = menuTable;

            menuDataGrid.DataSource = items;
        }

        private void modifyMenu_FormClosing(object sender, EventArgs e)
        {
            menuItemDatabase menuItem = new menuItemDatabase();
            menuItem.AddAllToDatabase(menuDataGrid);
        }

        private void btnModItem_Click(object sender, EventArgs e)
        {
            MenuItem.UpdateMenuItem(menuDataGrid, comboMod, txtMod);
        }
    }
}
