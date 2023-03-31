namespace ManageStudent_3Layer
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
            lbAccountType = new Label();
            lbUserName = new Label();
            lbPassword = new Label();
            cmbAccountType = new ComboBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbAccountType
            // 
            lbAccountType.AutoSize = true;
            lbAccountType.Location = new Point(84, 61);
            lbAccountType.Name = "lbAccountType";
            lbAccountType.Size = new Size(98, 20);
            lbAccountType.TabIndex = 0;
            lbAccountType.Text = "Account Type";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(84, 117);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(78, 20);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(88, 179);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Admin", "Teacher" });
            cmbAccountType.Location = new Point(201, 58);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(151, 28);
            cmbAccountType.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(201, 114);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(151, 27);
            txtUserName.TabIndex = 4;

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(129, 255);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(276, 255);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 372);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(cmbAccountType);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(lbAccountType);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAccountType;
        private Label lbUserName;
        private Label lbPassword;
        private ComboBox cmbAccountType;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
    }
}