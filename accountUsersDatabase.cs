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
    public class accountUsersDatabase
    {
        OleDbConnection myConnection;
        DataSet userDataSet;
        OleDbDataAdapter myDataAdapter;
        OleDbCommand userCommand;
        string userSQL;


        public accountUsersDatabase()
        {

        }

        public static bool checkUserCredientals(string accountUserName, string accountPassword, string accountUserType)
        {
            string userSQL = "SELECT COUNT(*) FROM AccountUsers WHERE accountUserName = @AccountUserName AND accountPassword = @AccountPassword AND accountUserType = @AccountUserType";

            using (OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AccountUsers.xlsx;Extended Properties=Excel 12.0"))
            using (OleDbCommand userCommand = new OleDbCommand(userSQL, myConnection))
            {
                userCommand.Parameters.AddWithValue("@AccountUserName", accountUserName);
                userCommand.Parameters.AddWithValue("@AccountPassword", accountPassword);
                userCommand.Parameters.AddWithValue("@AccountUserType", accountUserType);

                myConnection.Open();

                int matchCount = (int)userCommand.ExecuteScalar();

                if (matchCount == 1)
                {
                    // Match found
                    return true;
                }
                else
                {
                    // No match found
                    return false;
                }
            }
        }


       /* public void addUserToDatabase(accountUsers account)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OrderingSystem.accdb");
            myConnection.Open();
            userSQL = "INSERT INTO AccountUsers (AccountUserName, AccountPassword, AccountUserType) VALUES ('" + account.AccountUserName + "', '" + account.AccountUserPassword + "' , '" + account.AccountUserType + "') ";
            userCommand = new OleDbCommand(userSQL, myConnection);
            userDataSet = new DataSet("user");
            userCommand.ExecuteNonQuery();
            myConnection.Close();
            
        } */


        public void addUserToExcel(accountUsers account)
        {
            string userSQL = "INSERT INTO AccountUsers (AccountUserName, AccountPassword, AccountUserType) VALUES ('" + account.AccountUserName + "', '" + account.AccountUserPassword + "' , '" + account.AccountUserType + "') ";

            OleDbConnection excelConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AccountUsers.xlsx;Extended Properties=Excel 12.0");
            excelConnection.Open();
            OleDbCommand excelCommand = new OleDbCommand(userSQL, excelConnection);
            excelCommand.ExecuteNonQuery();
            excelConnection.Close();
        }


    }
}
