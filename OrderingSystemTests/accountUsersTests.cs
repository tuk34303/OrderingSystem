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
    public class accountUsersTests
    {
        string accountUserName = "Josh";
        string accountUserPassword = "123";
        string accountUserType = "Server";


        [TestMethod()]
        public void accountUsersTest1()
        {
            accountUsers users = new accountUsers(accountUserName, accountUserPassword, accountUserType);
            Assert.AreEqual(users.AccountUserName, accountUserName);
            Assert.AreEqual(users.AccountUserPassword, accountUserPassword);
            Assert.AreEqual(users.AccountUserType, accountUserType);
        }

        [TestMethod()]
        public void accountUsersTest2()
        {
            string accountUserName2 = "Jake";
            string accountUserPassword2 = "pass";
            string accountUserType2 = "Manager";


            accountUsers users = new accountUsers(accountUserName, accountUserPassword2, accountUserType2);
            Assert.AreNotEqual(users.AccountUserName, accountUserName2);
            Assert.AreNotEqual(users.AccountUserPassword, accountUserPassword);
            Assert.AreEqual(users.AccountUserType, accountUserType2);
            Assert.AreEqual(users.AccountUserPassword, accountUserPassword2);
        }

        [TestMethod()]
        public void accountUsersTest3()
        {
            string accountUserName3 = "Jake";
            string accountUserPassword3 = "pass";
            string accountUserType3 = "Manager";


            accountUsers users = new accountUsers(accountUserName3, accountUserPassword, accountUserType3);
            Assert.AreEqual(users.AccountUserName, accountUserName3);
            Assert.AreNotEqual(users.AccountUserName, accountUserName);
            Assert.AreEqual(users.AccountUserType, accountUserType3);
            Assert.AreEqual(users.AccountUserPassword, accountUserPassword);
            Assert.AreNotEqual(users.AccountUserPassword, accountUserPassword3);
        }


    }
}