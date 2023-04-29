using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Tests
{
    [TestClass()]
    public class accountUsersDatabaseTests
    {
        string accountUserName = "Amy";
        string accountPassword = "word";
        string accountUserType = "Manager";

        [TestMethod()]
        public void accountUsersDatabaseTest()
        {
           
        }

        [TestMethod()]
        public void checkUserCredientalsTest()
        {
            bool resultCheck = accountUsersDatabase.checkUserCredientals(accountUserName, accountPassword, accountUserType);
            Assert.IsTrue(resultCheck);
        }

        [TestMethod()]
        public void addUserToExcelTest()
        {
           
        }
    }
}