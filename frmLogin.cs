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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = comboUserType.Text;

            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Please input in username for your account");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Please input in password for your account");
            }

            if (string.IsNullOrEmpty(userType))
            {
                throw new Exception("Please input in type of User you are, for your account");
            }


            // Check if user exists
            if (accountUsersDatabase.checkUserCredientals(username, password, userType))
            {
                // If user exists, check user type
                if (userType == "Server")
                {
                    // Give server access
                    frmOrder theOrderForm = new frmOrder();
                    theOrderForm.ShowDialog();
                }
                else if (userType == "Kitchen Staff")
                {
                    // Give kitchen staff access
                    frmViewOrders theViewOrdersForm = new frmViewOrders();
                    theViewOrdersForm.ShowDialog();
                }
                else if (userType == "Manager")
                {
                    // Give manager access
                    frmMainMenu theMainMenuForm = new frmMainMenu();
                    theMainMenuForm.ShowDialog();
                }
                else
                {
                    // Invalid user type
                    throw new Exception("Invalid user type");
                }
            }
            else
            {
                // If user does not exist or credentials are invalid, throw exception
                throw new Exception("Invalid credentials");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
        }
    }
}
