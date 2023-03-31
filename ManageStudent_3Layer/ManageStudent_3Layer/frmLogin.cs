using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent_3Layer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string UserName = "";
        public string Password = "";
        public string AccountType;


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbAccountType.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose type of Account");
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter a UserName");
                txtUserName.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a Password");
            }


            UserName = txtUserName.Text;
            AccountType = "";


            switch (cmbAccountType.Text)
            {
                case "Admin":
                    AccountType = "Admin";
                    break;
                case "Teacher":
                    AccountType = "Teacher";
                    break;
            }

            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@AccountType",
                    value = AccountType
                },
                new CustomParameter()
                {
                    key = "@UserName",
                    value = txtUserName.Text
                },
                new CustomParameter()
                {
                    key = "@Password",
                    value = txtPassword.Text
                }
            };

            var rs = new Database().SelectData("Login", lstPara);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Login suceesfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is not valid");
            }
        }

       
    }
}
