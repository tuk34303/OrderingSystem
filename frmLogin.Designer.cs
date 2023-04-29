
namespace OrderingSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.usernameIbl = new System.Windows.Forms.Label();
            this.passwordIbl = new System.Windows.Forms.Label();
            this.userTypeIbl = new System.Windows.Forms.Label();
            this.orIbl = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(343, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(343, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(343, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usernameIbl
            // 
            this.usernameIbl.AutoSize = true;
            this.usernameIbl.Location = new System.Drawing.Point(222, 83);
            this.usernameIbl.Name = "usernameIbl";
            this.usernameIbl.Size = new System.Drawing.Size(115, 17);
            this.usernameIbl.TabIndex = 4;
            this.usernameIbl.Text = "Enter Username:";
            // 
            // passwordIbl
            // 
            this.passwordIbl.AutoSize = true;
            this.passwordIbl.Location = new System.Drawing.Point(222, 124);
            this.passwordIbl.Name = "passwordIbl";
            this.passwordIbl.Size = new System.Drawing.Size(110, 17);
            this.passwordIbl.TabIndex = 5;
            this.passwordIbl.Text = "Enter password:";
            // 
            // userTypeIbl
            // 
            this.userTypeIbl.AutoSize = true;
            this.userTypeIbl.Location = new System.Drawing.Point(216, 175);
            this.userTypeIbl.Name = "userTypeIbl";
            this.userTypeIbl.Size = new System.Drawing.Size(116, 17);
            this.userTypeIbl.TabIndex = 6;
            this.userTypeIbl.Text = "Enter User Type:";
            // 
            // orIbl
            // 
            this.orIbl.AutoSize = true;
            this.orIbl.Location = new System.Drawing.Point(373, 289);
            this.orIbl.Name = "orIbl";
            this.orIbl.Size = new System.Drawing.Size(29, 17);
            this.orIbl.TabIndex = 7;
            this.orIbl.Text = "OR";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(343, 326);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 38);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // comboUserType
            // 
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Manager",
            "Server",
            "Kitchen Staff"});
            this.comboUserType.Location = new System.Drawing.Point(343, 175);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(121, 24);
            this.comboUserType.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboUserType);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.orIbl);
            this.Controls.Add(this.userTypeIbl);
            this.Controls.Add(this.passwordIbl);
            this.Controls.Add(this.usernameIbl);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label usernameIbl;
        private System.Windows.Forms.Label passwordIbl;
        private System.Windows.Forms.Label userTypeIbl;
        private System.Windows.Forms.Label orIbl;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox comboUserType;
    }
}