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
    class orderDatabase
    {
        OleDbConnection myConnection;
        DataSet orderDataSet;
        OleDbDataAdapter myDataAdapter;
        OleDbCommand orderCommand;
        string orderSQL;

        public orderDatabase()
        {

        }

      /* public void addOrdertoDatabase(Order order)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            orderSQL = "INSERT INTO Order(OrderNumber, TableNumber, OrderTime, Cost) VALUES('" + order.OrderNumber + "', '" + order.TableNumber + "', '" + order.OrderDateTime + "', '"+ order.Cost + "') ";
            orderCommand = new OleDbCommand(orderSQL, myConnection);
            orderDataSet = new DataSet("userTable");
            orderCommand.ExecuteNonQuery();
            myConnection.Close();
        }
       */
        
    }
}
