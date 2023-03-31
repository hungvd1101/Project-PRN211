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
    public partial class frmTeacherDetails : Form
    {
        public frmTeacherDetails(string TeacherId)
        {
            this.TeacherId = TeacherId;
            InitializeComponent();
        }
        private string TeacherId;
        private string executor = "admin";
        private void frmTeacherDetails_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TeacherId))
            {
                this.Text = "Add new Teacher";
                btnDelete.Enabled = false;
            }
            else
            {
                this.Text = "Update Teacher";
                var r = new Database().Select("SelectTeacher '" + int.Parse(TeacherId) + "'");
                txtTeacherName.Text = r["TeacherName"].ToString();
                rdMale.Checked = r["Sex"].ToString() == "1" ? true : false;
                mtbDOB.Text = r["DOB"].ToString();

                txtPhoneNumber.Text = r["PhoneNumber"].ToString();
                txtEmail.Text = r["Email"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime DOB;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            try
            {
                DOB = DateTime.ParseExact(mtbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {

                MessageBox.Show("Ngay sinh khong hop le");
                mtbDOB.Select();
                return;
            }
            if (string.IsNullOrEmpty(TeacherId))
            {
                sql = "InsertTeacher";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Creator",
                    value = executor
                });
            }
            else
            {
                sql = "UpdateTeacher";
                lstPara.Add(new CustomParameter()
                {
                    key = "@TeacherId",
                    value = TeacherId
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@TeacherName",
                value = txtTeacherName.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DOB",
                value = DOB.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Sex",
                value = rdMale.Checked ? "1" : "0"
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@PhoneNumber",
                value = txtPhoneNumber.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = txtEmail.Text
            });

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(TeacherId))
                {
                    MessageBox.Show("Add new Teacher successfully");
                }
                else
                {
                    MessageBox.Show("Update Teacher successfully");

                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = new Database().Select("SelectTeacher '" + TeacherId + "'");
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            sql = "DeleteTeacher";
            lstPara.Add(new CustomParameter()
            {
                key = "@TeacherId",
                value = TeacherId,

            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Delete Teacher successfully");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }
    }
}
