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
    public partial class frmClassDetails : Form
    {
        public frmClassDetails(string ClassId)
        {
            InitializeComponent();
            this.ClassId = ClassId;
        }
        private string ClassId;
        private Database db;
        private string executor = "admin";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClassDetails_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@KeyWord",
                    value = ""
                }
            };

            cmbSubject.DataSource = db.SelectData("SelectAllSubject", lstPara);
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
            cmbSubject.SelectedIndex = -1;

            cmbTeacher.DataSource = db.SelectData("SelectAllTeacher", lstPara);
            cmbTeacher.DisplayMember = "TeacherName";
            cmbTeacher.ValueMember = "TeacherId";
            cmbTeacher.SelectedIndex = -1;

            if (string.IsNullOrEmpty(this.ClassId))
            {
                this.Text = "Add new class";
                btnDelete.Enabled = false;
            }
            else
            {
                this.Text = "Update class";
                var r = db.Select("exec SelectClass '" + ClassId + "'");
                cmbTeacher.SelectedValue = r["TeacherId"].ToString();
                cmbSubject.SelectedValue = r["SubjectId"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cmbSubject.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Subject");
                return;
            }
            if (cmbTeacher.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Teacher");
                return;
            }

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(this.ClassId))
            {
                sql = "InsertClass";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Creator",
                    value = executor
                });
            }
            else
            {
                sql = "UpdateClass";
                lstPara.Add(new CustomParameter()
                {
                    key = "@ClassId",
                    value = ClassId
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@SubjectId",
                value = cmbSubject.SelectedValue.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TeacherId",
                value = cmbTeacher.SelectedValue.ToString()
            });

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(ClassId))
                {
                    MessageBox.Show("Add new Class successfully");
                }
                else
                {
                    MessageBox.Show("Update Class successfully");

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
            var r = new Database().Select("SelectClass '" + ClassId + "'");
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            sql = "DeleteClass";
            lstPara.Add(new CustomParameter()
            {
                key = "@ClassId",
                value = ClassId,

            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Delete Class successfully");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }
    }
}
