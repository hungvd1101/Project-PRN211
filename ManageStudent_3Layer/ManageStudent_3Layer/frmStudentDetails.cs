using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent_3Layer
{
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails(string StudentId, string StudentName)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            InitializeComponent();
        }
        private string StudentId;
        private string StudentName;
        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentId))
            {
                this.Text = "Add new Student";
                btnDelete.Enabled = false;
            }
            else
            {
                this.Text = "Update Student";
                var r = new Database().Select("SelectStudent '" + StudentId + "'");

                txtStudentName.Text = r["StudentName"].ToString();
                mtbDOB.Text = r["DOB"].ToString();

                txtPhoneNumber.Text = r["PhoneNumber"].ToString();
                txtEmail.Text = r["Email"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 2 TH: 
            // 1: if StudentID null -> Add 
            // 2: if StudentID exist -> Update
            var r = new Database().Select("SelectStudent '" + StudentId + "'");

            // lay du lieu tu form
            string sql = "";
            string StudentName = txtStudentName.Text;
            DateTime DOB;
            try
            {
                DOB = DateTime.ParseExact(mtbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbDOB.Select();
                return;
            }

            string Sex = rdMale.Checked ? "1" : "0";
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(StudentId)) // Add
            {
                sql = "InsertStudent";
            }
            else // Update
            {
                sql = "UpdateStudent";
                lstPara.Add(new CustomParameter()
                {
                    key = "@StudentId",
                    value = StudentId,

                });

            }
            lstPara.Add(new CustomParameter()
            {
                key = "@StudentName",
                value = StudentName,
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DOB",
                value = DOB.ToString("yyyy-MM-dd"),
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Sex",
                value = Sex,
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@PhoneNumber",
                value = PhoneNumber,
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email,
            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(StudentId))
                {
                    MessageBox.Show("Add new student succesfully");
                }
                else
                {
                    MessageBox.Show("Update new student succesfully");

                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = new Database().Select("SelectStudent '" + StudentId + "'");
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            sql = "DeleteStudent";
            lstPara.Add(new CustomParameter()
            {
                key = "@StudentId",
                value = StudentId,

            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Delete Student successfully");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }


    }
}
