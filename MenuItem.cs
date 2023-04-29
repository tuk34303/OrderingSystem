using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;




namespace OrderingSystem
{
    public enum MenuCategory 
    {
        Appetizer, Dessert, Drink, Entree, None, Salad 
    }

    public class MenuItem
    {
        private string description;
        private double price;
        private MenuCategory category;
        private double calories;
        private double carbs;
        private double fats;
        private double proteins;
        private double sodiumContent;
        private string ingredients;
        private string allergyInformation;
        
        

        public MenuItem()
        {
            description = "";
            price = 0.0;
            category = MenuCategory.None;
        }

        public MenuItem(string description, double price, MenuCategory category)
        {
            this.description = description;
            this.price = price;
            this.category = category;
        }

        public MenuItem(double calories, double carbs, double fats, double proteins, double sodiumContent)
        {
            this.calories = calories;
            this.carbs = carbs;
            this.fats = fats;
            this.proteins = proteins;
            this.sodiumContent = sodiumContent;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be a negative value");
            }
        }

        public MenuCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public double Carbs
        {
            get { return carbs; }
            set { carbs = value; }
        }

        public double Fats
        {
            get { return fats; }
            set { fats = value; }
        }

        public double Proteins
        {
            get { return proteins; }
            set { proteins = value; }
        }

        public double SodiumContent
        {
            get { return sodiumContent; }
            set { sodiumContent = value; }
        }

        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public string AllergyInfo
        {
            get { return allergyInformation; }
            set { allergyInformation = value; }
        }
        public static void UpdateMenuItem(DataGridView dataGridView, ComboBox itemComboBox, TextBox itemText)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string itemColumn = itemComboBox.SelectedItem.ToString();
                string newValue = itemText.Text;


                selectedRow.Cells[itemColumn].Value = newValue;
            }
        }

        public static void DisplayCalories(DataGridViewRow row)
        {
            
            double calories =  Convert.ToDouble(row.Cells[4].Value);
            double carbs = Convert.ToDouble(row.Cells[5].Value);
            double fats= Convert.ToDouble(row.Cells[6].Value);
            double proteins = Convert.ToDouble(row.Cells[7].Value);
            double sodiumContent = Convert.ToDouble(row.Cells[8].Value);
           

            MenuItem item = new MenuItem( calories, carbs, fats, proteins, sodiumContent);

            viewItemCalories viewItem = new viewItemCalories(item);
            viewItem.Show();
        }

    }
}
