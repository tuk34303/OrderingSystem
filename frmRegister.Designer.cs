
namespace OrderingSystem
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.userIbl = new System.Windows.Forms.Label();
            this.passwordIbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(324, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(324, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(324, 219);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // userIbl
            // 
            this.userIbl.AutoSize = true;
            this.userIbl.Location = new System.Drawing.Point(173, 68);
            this.userIbl.Name = "userIbl";
            this.userIbl.Size = new System.Drawing.Size(125, 17);
            this.userIbl.TabIndex = 4;
            this.userIbl.Text = "Create UserName:";
            // 
            // passwordIbl
            // 
            this.passwordIbl.AutoSize = true;
            this.passwordIbl.Location = new System.Drawing.Point(185, 116);
            this.passwordIbl.Name = "passwordIbl";
            this.passwordIbl.Size = new System.Drawing.Size(117, 17);
            this.passwordIbl.TabIndex = 5;
            this.passwordIbl.Text = "create Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter User Type:";
            // 
            // txtUserType
            // 
            this.txtUserType.FormattingEnabled = true;
            this.txtUserType.Items.AddRange(new object[] {
            "Manager",
            "Server",
            "Kitchen Staff"});
            this.txtUserType.Location = new System.Drawing.Point(324, 169);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(121, 24);
            this.txtUserType.TabIndex = 7;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordIbl);
            this.Controls.Add(this.userIbl);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label userIbl;
        private System.Windows.Forms.Label passwordIbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtUserType;
    }
}