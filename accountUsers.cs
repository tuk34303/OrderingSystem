using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class accountUsers
    {
        private string accountUserName;
        private string accountUserPassword;
        private string accountUserType;

        public accountUsers()
        {

        }

        public accountUsers(string accountUserName, string accountUserPassword, string accountUserType)
        {
            this.accountUserName = accountUserName;
            this.accountUserPassword = accountUserPassword;
            this.accountUserType = accountUserType;
        }

        public string AccountUserName
        {
            get{ return accountUserName;}
            set {accountUserName = value;}
        }

        public string AccountUserPassword
        {
            get {return accountUserPassword;}
            set {accountUserPassword = value;}
        }

        public string AccountUserType
        {
            get { return accountUserType; }
            set { accountUserType = value; }
        }
    }
}
