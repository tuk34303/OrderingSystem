using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class frmModifyMenu : Form
    {
        menuItemDatabase menuData = new menuItemDatabase();
        MenuItem item = new MenuItem();
        
        public frmModifyMenu()
        {
            InitializeComponent();
        }

        private void btnAddToMenu_Click(object sender, EventArgs e)
        {
            MenuItem item = new MenuItem();
            double price = 0;
            
            if (double.TryParse(txtPrice.Text, out price) &&
                double.Parse(txtPrice.Text) > 0)
            {
                if (txtDesc.Text != "")
                {
                    item.Price = price;
                    item.Category = (MenuCategory)cboCategory.SelectedIndex;
                    item.Description = txtDesc.Text;

                    if(double.Parse(caloriestxt.Text) < 0)
                    {
                        throw new Exception("input has to be at the very least 0 or greater");
                    }
                    else
                    {
                        item.Calories = double.Parse(caloriestxt.Text);
                    }

                    if (double.Parse(carbstxt.Text) < 0)
                    {
                        throw new Exception("input has to be at the very least 0 or greater");
                    }
                    else
                    {
                        item.Carbs = double.Parse(carbstxt.Text);
                    }

                    if (double.Parse(fatstxt.Text) < 0)
                    {
                        throw new Exception("input has to be at the very least 0 or greater");
                    }
                    else
                    {
                        item.Fats = double.Parse(fatstxt.Text);
                    }

                    if (double.Parse(proteintxt.Text) < 0)
                    {
                        throw new Exception("input has to be at the very least 0 or greater");
                    }
                    else
                    {
                        item.Proteins = double.Parse(proteintxt.Text);
                    }

                    if (double.Parse(sodiumtxt.Text) < 0)
                    {
                        throw new Exception("input has to be at the very least 0 or greater");
                    }
                    else
                    {
                        item.SodiumContent = double.Parse(sodiumtxt.Text);
                    }


                    if (ingredientstxt.Text.Any(char.IsDigit))
                    {
                        throw new Exception("input has to be string value");
                    }
                    else
                    {
                        item.Ingredients = ingredientstxt.Text;
                    }

                    if (allergyInfotxt.Text.Any(char.IsDigit))
                    {
                        throw new Exception("input has to be string value");
                    }
                    else
                    {
                        item.AllergyInfo = allergyInfotxt.Text;
                    }
                    

                    // Use the system from the GlobalData class
                    GlobalData.MenuOrderingSystem.AddToMenu(item);

                    // Reset the form's controls
                    cboCategory.SelectedIndex = -1;
                    txtDesc.Text = "";
                    txtPrice.Text = "";
                    MessageBox.Show("The item was successfully added to the menu.", "Menu Entry Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enter a description for the item.", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else 
            {
                MessageBox.Show("Enter a valid price for the item.", "Invalid Input", 
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            menuData.addItemToMenuDatabase(item, item.Category);
        }

        private void cboCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* lstMenu.Items.Clear();

             MenuCategory category = (MenuCategory)cboCategoryList.SelectedIndex;

             // Use the system from the GlobalData class
             ArrayList items = GlobalData.MenuOrderingSystem.GetMenu(category);

             for (int i = 0; i < items.Count; i++)
             {
                 MenuItem item = (MenuItem)items[i];
                 lstMenu.Items.Add(item.Description);
                 lstMenu.Items[i].SubItems.Add(item.Price.ToString("C"));
             } */

            
            removeItemDataGrid.Rows.Clear();

            MenuCategory category = (MenuCategory)cboCategoryList.SelectedIndex;

            // Use the system from the GlobalData class
            ArrayList items = GlobalData.MenuOrderingSystem.GetMenu(category);

            for (int i = 0; i < items.Count; i++)
            {
                MenuItem item = (MenuItem)items[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(removeItemDataGrid);
                row.Cells[0].Value = item.Description;
                row.Cells[1].Value = item.Price.ToString("C");
                removeItemDataGrid.Rows.Add(row);
            }




        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool removed = false;
            string removedItems = "";

            for (int i = 0; i < lstMenu.SelectedItems.Count; i++)
            {
                MenuItem item = new MenuItem();
                item.Category = (MenuCategory)cboCategoryList.SelectedIndex;
                item.Description = lstMenu.SelectedItems[i].SubItems[0].Text;
                item.Price = double.Parse(lstMenu.SelectedItems[i].SubItems[1].Text, NumberStyles.Currency);


                

                // Use the system from the GlobalData class
                if (GlobalData.MenuOrderingSystem.RemoveFromMenu(item) == true)
                {
                    removedItems = removedItems + item.Description + "\n";
                    removed = true;
                    menuData.removeItemFromMenuDatabase(item);
                }
            }

            if (removed == true)
            {
                lstMenu.Items.Clear();
                MessageBox.Show("The following items were removed from the menu:\n"  + removedItems,
                                "Menu Change Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           










            
        }

        private void frmModifyMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderingSystemDataSet1.menuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.orderingSystemDataSet1.menuItem);

        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
