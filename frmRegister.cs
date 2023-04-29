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
    public partial class frmRegister : Form
    {
        accountUsersDatabase userData = new accountUsersDatabase();
        
        frmLogin login = new frmLogin();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            accountUsers  account = new accountUsers(txtUsername.Text, txtPassword.Text, txtUserType.Text);

            if (string.IsNullOrEmpty(account.AccountUserName) || string.IsNullOrEmpty(account.AccountUserPassword) || string.IsNullOrEmpty(account.AccountUserType))
            {
                throw new Exception("please create and enter data for all of the required field");
            }
            else
            {
                MessageBox.Show("thank you for registering!");
                userData.addUserToExcel(account);
                this.Hide();
                login.Show();
            }
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
