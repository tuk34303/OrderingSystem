using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OrderingSystem
{
    class menuItemDatabase
    {
        OleDbConnection myConnection;
        DataSet menuItemDataSet;
        OleDbDataAdapter myDataAdapter;
        OleDbCommand menuItemCommand;
        string menuItemSQL;


        public menuItemDatabase()
        {

        }

        public string addItemToMenuDatabase(MenuItem item, MenuCategory cat)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            menuItemSQL = "INSERT INTO menuItem (Category, Description, Price, Calories, Carbs, Fats, Proteins, SodiumContent, Ingredients, AllergyInformation) VALUES ('" + item.Category + "', '" + item.Description + "', '" + item.Price + "', " + item.Calories.ToString() + ", " + item.Carbs.ToString() + ", " + item.Fats.ToString() + ", " + item.Proteins.ToString() + ", " + item.SodiumContent.ToString() + ", '" + item.Ingredients + "', '" + item.AllergyInfo + "')";
            menuItemCommand = new OleDbCommand(menuItemSQL, myConnection);
            menuItemDataSet = new DataSet("userTable");
            menuItemCommand.ExecuteNonQuery();
            myConnection.Close();
            return "added item";
        }


        public void removeItemFromMenuDatabase(MenuItem item)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            menuItemSQL = $"DELETE FROM menuItem WHERE Description='{item.Description}' AND Price='{item.Price}'";
            menuItemCommand = new OleDbCommand(menuItemSQL, myConnection);
            menuItemCommand.ExecuteNonQuery();
            myConnection.Close();
        }


        public static DataTable loadFromMenuItemDatabase()
        {
            OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            string ItemSQL = "SELECT * FROM menuItem";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(ItemSQL, myConnection);
            DataTable userDataSet = new DataTable();
            myDataAdapter.Fill(userDataSet);

            myConnection.Close();

            return userDataSet;
        }

        public DataTable LoadMenuItemCategoryToMenu(MenuCategory category)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            string itemLoadSQL = "SELECT * FROM menuItem WHERE Category = '" + category.ToString() + "'";
            myDataAdapter = new OleDbDataAdapter(itemLoadSQL, myConnection);
            DataTable itemDataSet = new DataTable();
            myDataAdapter.Fill(itemDataSet);
            myConnection.Close();
            return itemDataSet;
         
            
        }

        public void AddAllToDatabase(DataGridView data)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            menuItemSQL = "DELETE * FROM menuItem";
            menuItemCommand = new OleDbCommand(menuItemSQL, myConnection);
            menuItemCommand.ExecuteNonQuery();
            myConnection.Close();

            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            menuItemCommand = new OleDbCommand(menuItemSQL, myConnection);

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.Cells[1].Value != null)
                {

                    string category = row.Cells[1].Value.ToString();
                    string description = row.Cells[2].Value.ToString();
                    string price = row.Cells[3].Value.ToString();
                    double calories = Convert.ToDouble(row.Cells[4].Value);
                    double carbs = Convert.ToDouble(row.Cells[5].Value);
                    double fats = Convert.ToDouble(row.Cells[6].Value);
                    double proteins = Convert.ToDouble(row.Cells[7].Value);
                    double sodiumContent = Convert.ToDouble(row.Cells[8].Value);
                    string Ingredients = row.Cells[9].Value.ToString();
                    string allergyInfo = row.Cells[10].Value.ToString();

                    menuItemSQL = $"INSERT INTO menuItem (Category, Description, Price, Calories, Carbs, Fats, Proteins, SodiumContent, Ingredients, AllergyInformation) VALUES ('{category}', '{description}', '{price}', {calories}, {carbs}, {fats}, {proteins}, {sodiumContent}, '{Ingredients}', '{allergyInfo}')";

                    menuItemCommand = new OleDbCommand(menuItemSQL, myConnection);
                    menuItemCommand.ExecuteNonQuery();

                }
            }
            myConnection.Close();
        }

        public DataTable searchItemForRemoval(string category)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            menuItemSQL = "SELECT * FROM menuItem WHERE Category = '" + category + "'";
            myDataAdapter = new OleDbDataAdapter(menuItemSQL, myConnection);
            DataTable menuItemDataSet = new DataTable();
            myDataAdapter.Fill(menuItemDataSet);

            return menuItemDataSet;
        }

    }


}
